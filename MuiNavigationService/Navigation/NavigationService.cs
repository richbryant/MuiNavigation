using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using FirstFloor.ModernUI.Windows.Controls;

namespace MuiNavigationService.Navigation
{
    public class NavigationService : INavigationService
    {
        private readonly Dictionary<string, Uri> _pagesByKey;
        private readonly List<string> _historic;

        public NavigationService()
        {
            _pagesByKey = new Dictionary<string, Uri>();
            _historic = new List<string>();
        }

        public string CurrentPageKey
        {
            get;
            private set;
        }

        public void GoBack()
        {
            if (_historic.Count > 1)
            {
                _historic.RemoveAt(_historic.Count - 1);
                NavigateTo(_historic.Last(), null);
            }
        }

        public void NavigateTo(string pageKey)
        {
            NavigateTo(pageKey, null);
        }

        public virtual void NavigateTo(string pageKey, object parameter)
        {
            lock (_pagesByKey)
            {
                if (!_pagesByKey.ContainsKey(pageKey))
                {
                    throw new ArgumentException(
                        $@"No such page: {pageKey}. Did you forget to call NavigationService.Configure?", nameof(pageKey));
                }

                // Set the frame source, which initiates navigation
                if (GetDescendantFromName(Application.Current.MainWindow, "ContentFrame") is ModernFrame frame)
                {
                    frame.Source = _pagesByKey[pageKey];
                }
                Parameter = parameter;
                _historic.Add(pageKey);
                CurrentPageKey = pageKey;
            }
        }

        public void Configure(string key, Uri pageType)
        {
            lock (_pagesByKey)
            {
                if (_pagesByKey.ContainsKey(key))
                {
                    _pagesByKey[key] = pageType;
                }
                else
                {
                    _pagesByKey.Add(key, pageType);
                }
            }
        }

        private static FrameworkElement GetDescendantFromName(DependencyObject parent, string name)
        {
            var count = VisualTreeHelper.GetChildrenCount(parent);

            if (count < 1)
            {
                return null;
            }

            for (var i = 0; i < count; i++)
            {
                if (!(VisualTreeHelper.GetChild(parent, i) is FrameworkElement frameworkElement)) continue;
                if (frameworkElement.Name == name)
                {
                    return frameworkElement;
                }

                frameworkElement = GetDescendantFromName(frameworkElement, name);
                if (frameworkElement != null)
                {
                    return frameworkElement;
                }
            }

            return null;
        }

        public object Parameter { get; private set; }
    }
}
