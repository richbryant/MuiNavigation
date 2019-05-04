using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Core.ViewModels;
using MuiPrismNavigation.Models;
using MuiPrismNavigation.Services;
using Prism.Commands;

namespace MuiPrismNavigation.ViewModels
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

        private void GridClick(Customer customer)
        {
            Debug.WriteLine("Got clicked");
            Debug.WriteLine($"{customer.FirstName} {customer.LastName}");

        }

        public Uri NavigateTarget => new Uri("/Views/CustomerDetails.xaml#Id=" + Selected?.Id, UriKind.Relative);
    }
}
