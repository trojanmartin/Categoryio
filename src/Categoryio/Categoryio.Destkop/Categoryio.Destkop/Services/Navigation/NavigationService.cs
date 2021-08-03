using Categoryio.Destkop.Base;
using Categoryio.Destkop.Pages;
using Categoryio.Destkop.ViewModels;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Categoryio.Destkop.Services.Navigation
{
    internal class NavigationService : INavigationService
    {
        private Frame _shellFrame;

        public void InitializeFrame(Frame rootFrame)
        {
            _shellFrame = rootFrame;
            NavigateTo<ShellViewModel>();
        }

        public void NavigateTo<T>() where T : BaseViewModel
        {
            InternalNavigateTo(typeof(T), null);
        }

        public void NavigateTo<T>(object parameter) where T : BaseViewModel
        {
            InternalNavigateTo(typeof(T), parameter);
        }

        public void RemoveFromBackStack()
        {
            _shellFrame?.BackStack.Remove(_shellFrame.BackStack.Last());
        }

        private void InternalNavigateTo(Type viewModelType, object parameter)
        {
            var pageType = GetPageTypeForViewModel(viewModelType);
            _shellFrame?.Navigate(pageType, parameter);

            var content = _shellFrame.Content;
            if (content is ShellPage shellPage)
            {
                var navigationView = (shellPage.Content as Panel).Children.OfType<NavigationView>().First();
                var navFrame = (navigationView.Content as Panel).Children.OfType<Frame>().First();
                _shellFrame = navFrame;

                // navigate to book flight viewmodel
                NavigateTo<MainViewModel>();
            }
        }

        private Type GetPageTypeForViewModel(Type viewModelType)
        {
            var viewName = viewModelType.FullName.Replace("ViewModel", "Page");
            var viewModelAssemblyName = viewModelType.GetTypeInfo().Assembly.FullName;
            var viewAssemblyName = string.Format(CultureInfo.InvariantCulture, "{0}, {1}", viewName, viewModelAssemblyName);
            var viewType = Type.GetType(viewAssemblyName);
            return viewType;
        }
    }
}
