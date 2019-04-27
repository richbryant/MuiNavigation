﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FirstFloor.ModernUI.Windows;
using MuiNavigationService.Controls;
using FragmentNavigationEventArgs = FirstFloor.ModernUI.Windows.Navigation.FragmentNavigationEventArgs;

namespace MuiNavigationService.Views
{
    /// <summary>
    /// Interaction logic for CustomerDetails.xaml
    /// </summary>
    public partial class CustomerDetails : MuiControl
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        public override void OnFragmentNavigation(FragmentNavigationEventArgs e)
        {
            var viewModel = DataContext as IContent;
            viewModel?.OnFragmentNavigation(e);
        }
    }
}