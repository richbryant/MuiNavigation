using Prism.Commands;
using System.Diagnostics;

namespace MuiNavigationService.ViewModels
{
    public class StepsViewModel : ViewModelBase
    {
        public StepsViewModel()
        {
            NavigatingFromCommand = new DelegateCommand(NavigatingFrom);
            NavigatedFromCommand = new DelegateCommand(NavigatedFrom);
            NavigatedToCommand = new DelegateCommand(NavigatedTo);
            FragmentNavigationCommand = new DelegateCommand(FragmentNavigation);
            LoadedCommand = new DelegateCommand(LoadData);
            IsVisibleChangedCommand = new DelegateCommand(VisibilityChanged);
        }

        private void VisibilityChanged()
        {
            Debug.WriteLine("ResourcesViewModel - VisibilityChanged");
        }

        private void LoadData()
        {
            Debug.WriteLine("StepsViewModel - LoadData");
        }

        private void NavigatedFrom()
        {

            Debug.WriteLine("StepsViewModel - NavigatedFrom");
        }

        private void NavigatedTo()
        {
            Debug.WriteLine("StepsViewModel - NavigatedTo");
        }

        private void FragmentNavigation()
        {
            Debug.WriteLine("StepsViewModel - FragmentNavigation");
        }

        private void NavigatingFrom()
        {
            Debug.WriteLine("StepsViewModel - NavigatingFrom");
        }
    }
}
