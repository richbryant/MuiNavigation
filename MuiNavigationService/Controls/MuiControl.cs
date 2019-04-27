using System.Windows.Controls;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Navigation;

namespace MuiNavigationService.Controls
{
    public class MuiControl : UserControl, IContent
    {
        public virtual void OnFragmentNavigation(FragmentNavigationEventArgs e)
        {
            var viewModel = DataContext as IContent;
            viewModel?.OnFragmentNavigation(e);
        }

        public virtual void OnNavigatedFrom(NavigationEventArgs e)
        {
            var viewModel = DataContext as IContent;
            viewModel?.OnNavigatedFrom(e);
        }

        public virtual void OnNavigatedTo(NavigationEventArgs e)
        {
            var viewModel = DataContext as IContent;
            viewModel?.OnNavigatedTo(e);
        }

        public virtual void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            var viewModel = DataContext as IContent;
            viewModel?.OnNavigatingFrom(e);
        }

    }
}
