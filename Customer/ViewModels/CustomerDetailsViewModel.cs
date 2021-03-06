﻿using System.Linq;
using Core.Models;
using Core.Services;
using Core.ViewModels;
using FirstFloor.ModernUI.Windows.Navigation;

namespace MuiPrismNavigation.ViewModels
{
    public class CustomerDetailsViewModel : ViewModelBase
    {
        private Core.Models.Customer _customer = new Core.Models.Customer();
        private Core.Models.Customer _referenceCopy;
        private readonly ICustomerService _customerService;

        public CustomerDetailsViewModel(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        public CustomerDetailsViewModel(Core.Models.Customer data)
        {
            _customer = data;
            _referenceCopy = data.Clone() as Core.Models.Customer;
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

        private void Load(int id)
        {
            if (_customerService != null)
            {
                var data = _customerService.Get().First(x => x.Id == id);
                _customer = data;
                _referenceCopy = data.Clone() as Core.Models.Customer;
                RaisePropertyChanged(nameof(Id));
                RaisePropertyChanged(nameof(FirstName));
                RaisePropertyChanged(nameof(LastName));
                RaisePropertyChanged(nameof(Email));
                RaisePropertyChanged(nameof(IsMember));
                RaisePropertyChanged(nameof(Status));
            }
            
        }

        public override void OnFragmentNavigation(FragmentNavigationEventArgs e)
        {
            if (int.TryParse(e.Fragment.Replace("Id=", ""), out var id))
            {
                Load(id);
            }
        }
    }
}
