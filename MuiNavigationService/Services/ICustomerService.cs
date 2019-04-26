using System.Collections.Generic;
using MuiNavigationService.Models;

namespace MuiNavigationService.Services
{
    public interface ICustomerService
    {
        List<Customer> Get();
    }
}