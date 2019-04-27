using MuiNavigationService.Models;

namespace MuiNavigationService.ViewModels
{
    public class CustomerDetailsViewModel : ViewModelBase
    {
        private readonly Customer _customer;
        private readonly Customer _referenceCopy;

        public CustomerDetailsViewModel(Customer data)
        {
            _customer = data;
            _referenceCopy = data.Clone() as Customer;
        }

        public int Id
        {
            get => _customer.Id;
            set
            {
                _customer.Id = value;
                RaisePropertyChanged();
            }
        }

        public string FirstName
        {
            get => _customer.FirstName;
            set
            {
                _customer.FirstName = value;
                RaisePropertyChanged();
            }
        }

        public string LastName
        {
            get => _customer.LastName;
            set
            {
                _customer.LastName = value;
                RaisePropertyChanged();
            }
        }

        public string Email
        {
            get => _customer.Email;
            set
            {
                _customer.Email = value;
                RaisePropertyChanged();
            }
        }

        public bool IsMember
        {
            get => _customer.IsMember;
            set 
            { 
                _customer.IsMember = value;
                RaisePropertyChanged();
            }
        }

        public OrderStatus Status
        {
            get => _customer.Status;
            set
            {
                _customer.Status = value;
                RaisePropertyChanged();
            }
        }

        public bool Dirty => _referenceCopy.Equals(_customer);
    }
}
