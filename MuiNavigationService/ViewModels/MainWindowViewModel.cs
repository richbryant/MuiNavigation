using System;
using System.Reflection;
using System.Reflection.Emit;
using Core.Services.Core.Services;
using Core.ViewModels;
using Customer;
using FirstFloor.ModernUI.Presentation;
using ImTools;
using MuiPrismNavigation.Views;
using Prism.Modularity;

namespace MuiPrismNavigation.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _title = "Prism Application";
        private LinkGroupCollection _menu = new LinkGroupCollection();

        public MainWindowViewModel(IModuleCatalog catalog)
        {
            LoadMenu(catalog);
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public LinkGroupCollection Menu
        {
            get => _menu;
            set => SetProperty(ref _menu, value);
        }

        private void LoadMenu(IModuleCatalog catalog)
        {
            var group = new LinkGroup
            {
                DisplayName = "Home"
            };
            group.Links.Add(new Link {DisplayName = "Home", Source = GetUri(typeof(Intro))});
            Menu.Add(group);

            var c = new CustomerModule();
            Menu.Add(c.GetLinkGroup());
        }


        private Uri GetUri(Type viewType)
        {
            return new Uri($"/../Views/{viewType.Name}.xaml", UriKind.Relative);
        }
    }
}
