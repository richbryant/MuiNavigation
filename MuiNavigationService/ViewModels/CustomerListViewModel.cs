using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using MuiNavigationService.Models;
using MuiNavigationService.Services;
using Prism.Commands;

namespace MuiNavigationService.ViewModels
{
    public class CustomerListViewModel : ViewModelBase
    {
        public DelegateCommand<Customer> MouseDoubleClickEvent { get; set; }
        public CustomerListViewModel(ICustomerService service)
        {
            Customers = new ObservableCollection<Customer>();
            Customers.AddRange(service.Get());
            MouseDoubleClickEvent = new DelegateCommand<Customer>(GridClick);
        }

        private ObservableCollection<Customer> _customers;
        

        public ObservableCollection<Customer> Customers
        {
            get => _customers;
            set => SetProperty(ref _customers, value);
        }

        private Customer _selected;

        public Customer Selected
        {
            get => _selected;
            set
            {
                SetProperty(ref _selected, value);
                RaisePropertyChanged($"NavigateTarget");
            }
        }

        private void FragmentNavigation()
        {
            Debug.WriteLine("ResourcesViewModel - FragmentNavigation");
        }

        private void GridClick(Customer customer)
        {
            Debug.WriteLine("Got clicked");
            Debug.WriteLine($"{customer.FirstName} {customer.LastName}");

        }

        public Uri NavigateTarget => new Uri("/Views/CustomerDetails.xaml#Id=" + Selected?.Id, UriKind.Relative);
    }
}
