using System.Collections.Generic;
using Core.Models;

namespace Core.Services
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> Get()
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    FirstName = "Orlando",
                    LastName = "Gee",
                    Email = "orlando@adventure-works.com",
                    IsMember = true,
                    Status = OrderStatus.New
                },
                new Customer
                {
                    Id = 2,
                    FirstName = "Keith",
                    LastName = "Harris",
                    Email = "keith@adventure-works.com",
                    IsMember = true,
                    Status = OrderStatus.Received
                },
                new Customer
                {
                    Id = 3,
                    FirstName = "Donna",
                    LastName = "Carreras",
                    Email = "donna@adventure-works.com",
                    IsMember = false,
                    Status = OrderStatus.None
                },
                new Customer
                {
                    Id = 4,
                    FirstName = "Janet",
                    LastName = "Gates",
                    Email = "janet@adventure-works.com",
                    IsMember = true,
                    Status = OrderStatus.Shipped
                },
                new Customer
                {
                    Id = 5,
                    FirstName = "Lucy",
                    LastName = "Harrington",
                    Email = "lucy@adventure-works.com",
                    IsMember = false,
                    Status = OrderStatus.New
                },
                new Customer
                {
                    Id = 6,
                    FirstName = "Rosmarie",
                    LastName = "Carroll",
                    Email = "rosmarie@adventure-works.com",
                    IsMember = true,
                    Status = OrderStatus.Processing
                },
                new Customer
                {
                    Id = 7,
                    FirstName = "Dominic",
                    LastName = "Gash",
                    Email = "dominic@adventure-works.com",
                    IsMember = true,
                    Status = OrderStatus.Received
                },
                new Customer
                {
                    Id = 8,
                    FirstName = "Kathleen",
                    LastName = "Garza",
                    Email = "kathleen@adventure-works.com",
                    IsMember = false,
                    Status = OrderStatus.None
                },
                new Customer
                {
                    Id = 9,
                    FirstName = "Katherine",
                    LastName = "Harding",
                    Email = "katherine@adventure-works.com",
                    IsMember = true,
                    Status = OrderStatus.Shipped
                },
                new Customer
                {
                    Id = 10,
                    FirstName = "Johnny",
                    LastName = "Caprio",
                    Email = "johnny@adventure-works.com",
                    IsMember = false,
                    Status = OrderStatus.Processing
                }
            };


            return customers;
        }
    }
}
