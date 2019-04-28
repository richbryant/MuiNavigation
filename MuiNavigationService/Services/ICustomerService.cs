using System.Collections.Generic;
using MuiPrismNavigation.Models;

namespace MuiPrismNavigation.Services
{
    public interface ICustomerService
    {
        List<Customer> Get();
    }
}