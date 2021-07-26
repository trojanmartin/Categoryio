using Categoryio.Destkop.Base;

namespace Categoryio.Destkop.Services.Navigation
{
    public interface INavigationService
    {
        void InitializeFrame(Microsoft.UI.Xaml.Controls.Frame rootFrame);

        void NavigateTo<T>() where T : BaseViewModel;

        void NavigateTo<T>(object parameter) where T : BaseViewModel;

        void RemoveFromBackStack();
    }
}
