using Prism.Ioc;
using System.Windows;
using Core.Models;
using Core.Services;
using Customer;
using MuiPrismNavigation.Views;
using Prism.Modularity;

namespace MuiPrismNavigation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<CustomerModule>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ICustomerService, CustomerService>();
        }
    }
}
