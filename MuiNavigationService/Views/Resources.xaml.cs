using System.Diagnostics;
using System.Windows.Navigation;
using MuiPrismNavigation.Controls;

namespace MuiPrismNavigation.Views
{
    /// <summary>
    /// Interaction logic for Resources
    /// </summary>
    public partial class Resources : MuiControl
    {
        public Resources()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
