﻿using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Navigation;
using MuiNavigationService.Controls;

namespace MuiNavigationService.Views
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
