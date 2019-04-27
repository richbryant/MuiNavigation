using MuiNavigationService.Views;
using Prism.Ioc;
using System.Windows;
using MuiNavigationService.Services;

namespace MuiNavigationService
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

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ICustomerService, CustomerService>();
        }
    }
}
