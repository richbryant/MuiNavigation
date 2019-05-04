using System;
using Core.Services.Core.Services;
using Customer.Views;
using FirstFloor.ModernUI.Presentation;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Customer
{
    public class CustomerModule : IModule, IMenuService
    {
        public LinkGroup GetLinkGroup()
        {
            var linkGroup = new LinkGroup
            {
                DisplayName = "Customers"
            };

            linkGroup.Links.Add(new Link
            {
                DisplayName = "Listing",
                Source = new Uri($"/Customers;component/Views/{nameof(CustomerList)}.xaml", UriKind.Relative)
            });
            linkGroup.Links.Add(new Link
            {
                DisplayName = "Something Else",
                Source = new Uri($"/Customers;component/Views/{nameof(SomethingElse)}.xaml", UriKind.Relative)
            });

            return linkGroup;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
 
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}