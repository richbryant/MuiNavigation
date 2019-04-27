using System.Collections.ObjectModel;
using System.Diagnostics;
using MuiNavigationService.Models;
using MuiNavigationService.Services;

namespace MuiNavigationService.ViewModels
{
    public class CustomerListViewModel : ViewModelBase
    {
        public CustomerListViewModel(ICustomerService service)
        {
            Customers = new ObservableCollection<Customer>();
            Customers.AddRange(service.Get());
        }

        private ObservableCollection<Customer> _customers;
        public ObservableCollection<Customer> Customers
        {
            get => _customers;
            set => SetProperty(ref _customers, value);
        }

        private void FragmentNavigation()
        {
            Debug.WriteLine("ResourcesViewModel - FragmentNavigation");
        }
    }
}
