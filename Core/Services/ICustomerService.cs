using System.Collections.Generic;
using Core.Models;

namespace Core.Services
{
    public interface ICustomerService
    {
        List<Customer> Get();
    }
}