namespace MuiNavigationService.Navigation
{
    public interface INavigationService
    {
        void GoBack();

        void NavigateTo(string pageKey);

        void NavigateTo(string pageKey, object parameter);

        string CurrentPageKey { get; }

        object Parameter { get; }
    }
}