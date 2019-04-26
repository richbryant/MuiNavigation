using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace MuiNavigationService.ViewModels
{
    public abstract class ViewModelBase : BindableBase
    {
        public DelegateCommand NavigatingFromCommand { get; set; }

        public DelegateCommand NavigatedFromCommand { get; set; }

        public DelegateCommand NavigatedToCommand { get; set; }

        public DelegateCommand FragmentNavigationCommand { get; set; }

        public DelegateCommand LoadedCommand { get; set; }

        public DelegateCommand IsVisibleChangedCommand { get; set; }
    }
}
