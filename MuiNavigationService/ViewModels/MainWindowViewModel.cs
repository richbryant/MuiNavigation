using Core.ViewModels;

namespace MuiPrismNavigation.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
    }
}
