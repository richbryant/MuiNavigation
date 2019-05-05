using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Core.Services;
using Core.ViewModels;
using Prism.Commands;

namespace Customer.ViewModels
{
    public class CustomerListViewModel : ViewModelBase
    {
        public DelegateCommand<Core.Models.Customer> MouseDoubleClickEvent { get; set; }
        public CustomerListViewModel(ICustomerService service)
        {
            Customers = new ObservableCollection<Core.Models.Customer>();
            Customers.AddRange(service.Get());
            MouseDoubleClickEvent = new DelegateCommand<Core.Models.Customer>(GridClick);
        }

        private ObservableCollection<Core.Models.Customer> _customers;
        

        public ObservableCollection<Core.Models.Customer> Customers
        {
            get => _customers;
            set => SetProperty(ref _customers, value);
        }

        private Core.Models.Customer _selected;

        public Core.Models.Customer Selected
        {
            get => _selected;
            set
            {
                SetProperty(ref _selected, value);
                RaisePropertyChanged($"NavigateTarget");
            }
        }

        private void GridClick(Core.Models.Customer customer)
        {
            Debug.WriteLine("Got clicked");
            Debug.WriteLine($"{customer.FirstName} {customer.LastName}");

        }

        public Uri NavigateTarget => new Uri($"/Customer;component/Views/CustomerDetails.xaml#Id=" + Selected?.Id, UriKind.Relative);
    }
}
