using Categoryio.Destkop.Base;
using Categoryio.Destkop.Services.Navigation;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Categoryio.Destkop.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        private ObservableCollection<MenuItem> _menuItems;

        public ObservableCollection<MenuItem> MenuItems => _menuItems;
        public ICommand SelectedPageChangedCommand => new RelayParametrizedCommand<MenuItem>((value) => NavigateToMenuItem(value));

        public ShellViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            LoadMenuItems();
        }

        public void LoadMenuItems()
        {
            _menuItems = new ObservableCollection<MenuItem>();

            _menuItems.Add(new MenuItem { Name = "Hlavná obrazovka", Icon = "\uE709", ViewModelType = nameof(MainViewModel) });
            _menuItems.Add(new MenuItem { Name = "Kategórie", Icon = "\uE721", ViewModelType = nameof(CategoryViewModel) });
            _menuItems.Add(new MenuItem { Name = "Položky", Icon = "\uE721", ViewModelType = nameof(ItemViewModel) });
        }

        private void NavigateToMenuItem(MenuItem item)
        {
            switch (item.ViewModelType)
            {
                case nameof(MainViewModel):
                    _navigationService.NavigateTo<MainViewModel>();
                    break;
                case nameof(CategoryViewModel):
                    _navigationService.NavigateTo<CategoryViewModel>();
                    break;
                case nameof(ItemViewModel):
                    _navigationService.NavigateTo<ItemViewModel>();
                    break;
            }

            item.Selected = true;
        }
    }
    
    public class MenuItem
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public bool Selected { get; set; }
        public string ViewModelType { get; set; }
    }
}
