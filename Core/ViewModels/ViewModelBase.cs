using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Navigation;
using Prism.Mvvm;

namespace Core.ViewModels
{
    public abstract class ViewModelBase : BindableBase, IContent
    {
        public virtual void OnFragmentNavigation(FragmentNavigationEventArgs e)
        {
            
        }

        public virtual void OnNavigatedFrom(NavigationEventArgs e)
        {
            
        }

        public virtual void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        public virtual void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            
        }
    }
}
