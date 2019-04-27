using System.Diagnostics;

namespace MuiNavigationService.ViewModels
{
    public class ResourcesViewModel : ViewModelBase
    {
        public ResourcesViewModel()
        {}

        private void VisibilityChanged()
        {
            Debug.WriteLine("ResourcesViewModel - VisibilityChanged");
        }

        /// <summary>
        /// Loads the data.
        /// </summary>
        private void LoadData()
        {
            Debug.WriteLine("ResourcesViewModel - LoadData");
        }

        /// <summary>
        /// Navigateds from.
        /// </summary>
        private void NavigatedFrom()
        {
            // called when we navigated to another view
            Debug.WriteLine("ResourcesViewModel - NavigatedFrom");
        }

        /// <summary>
        /// Navigateds to.
        /// </summary>
        private void NavigatedTo()
        {
            // called when we navigate to the view related with this view model.
            Debug.WriteLine("ResourcesViewModel - NavigatedTo");
        }

        /// <summary>
        /// Fragments the navigation.
        /// </summary>
        private void FragmentNavigation()
        {
            Debug.WriteLine("ResourcesViewModel - FragmentNavigation");
        }

        /// <summary>
        /// Navigatings from.
        /// </summary>
        private void NavigatingFrom()
        {
            // Called when we will navigate to new view
            Debug.WriteLine("ResourcesViewModel - NavigatingFrom");
        }
    }
}
