using System.Windows.Controls;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Navigation;

namespace MuiNavigationService.Controls
{
    public class MuiControl : UserControl, IContent
    {
        public void OnFragmentNavigation(FragmentNavigationEventArgs e)
        {
            FragmentNavigation?.Invoke(this, e);
        }

        public void OnNavigatedFrom(NavigationEventArgs e)
        {
            NavigatedFrom?.Invoke(this, e);
        }

        public void OnNavigatedTo(NavigationEventArgs e)
        {
            NavigatedTo?.Invoke(this, e);
        }

        public void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            NavigatingFrom?.Invoke(this, e);
        }

        public event NavigatingCancelHandler NavigatingFrom;

        public event NavigationEventHandler NavigatedFrom;

        public event NavigationEventHandler NavigatedTo;

        public event FragmentNavigationHandler FragmentNavigation;

        public delegate void NavigatingCancelHandler(object sender, NavigatingCancelEventArgs e);

        public delegate void NavigationEventHandler(object sender, NavigationEventArgs e);

        public delegate void FragmentNavigationHandler(object sender, FragmentNavigationEventArgs e);
    }
}
