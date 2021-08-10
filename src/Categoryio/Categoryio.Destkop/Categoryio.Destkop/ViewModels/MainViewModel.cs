using Categoryio.Common.Entities;
using Categoryio.Destkop.Base;
using Categoryio.Destkop.Services.Navigation;
using System.Collections.Generic;
using System.Windows.Input;

namespace Categoryio.Destkop.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public ICommand NewItemCommand => new RelayCommand(() => NavigateToNewItem());

        public List<Category> Categories { get; set; }

        public Category SelectedCategory { get; set; }

        public MainViewModel(INavigationService navigationService)
        {
            Categories = new List<Category>()
            {
                new Category()
                {
                    Name = "Zvierata",
                    Created = System.DateTime.Now,
                    Theme = new Theme()
                    {
                        Name = "test1"
                    },
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            Id = 1,
                            Name = "Stolna hra",
                            Description = "pre 5 deti, super lahke",
                            Created = System.DateTime.Now
                        },
                        new Item()
                        {
                            Id = 2,
                            Name = "fotbal hra",
                            Description = "nebezpecne",
                            Created = System.DateTime.Now.AddDays(-10)
                        },
                        new Item()
                        {
                            Id = 3,
                            Name = "Pingpong hra",
                            Description = "pre 5 deti, super tazke",
                            Created = System.DateTime.Now.AddDays(5)
                        },
                        new Item()
                        {
                            Id = 1,
                            Name = "Stolna hra",
                            Description = "pre 5 deti, super lahke",
                            Created = System.DateTime.Now
                        },
                        new Item()
                        {
                            Id = 2,
                            Name = "fotbal hra",
                            Description = "nebezpecne",
                            Created = System.DateTime.Now.AddDays(-10)
                        },
                        new Item()
                        {
                            Id = 3,
                            Name = "Pingpong hra",
                            Description = "pre 5 deti, super tazke",
                            Created = System.DateTime.Now.AddDays(5)
                        },
                        new Item()
                        {
                            Id = 1,
                            Name = "Stolna hra",
                            Description = "pre 5 deti, super lahke",
                            Created = System.DateTime.Now
                        },
                        new Item()
                        {
                            Id = 2,
                            Name = "fotbal hra",
                            Description = "nebezpecne",
                            Created = System.DateTime.Now.AddDays(-10)
                        },
                        new Item()
                        {
                            Id = 3,
                            Name = "Pingpong hra",
                            Description = "pre 5 deti, super tazke",
                            Created = System.DateTime.Now.AddDays(5)
                        }
                    }
                },
                new Category()
                {
                    Name = "Logicke hry",
                    Created = System.DateTime.Now,
                      Theme = new Theme()
                    {
                        Name = "test1"
                    },
                },
                new Category()
                {
                    Name = "Logika",
                    Created = System.DateTime.Now,
                      Theme = new Theme()
                    {
                        Name = "test1"
                    },
                }
            };
            _navigationService = navigationService;
        }

        public void NavigateToNewItem()
        {
            _navigationService.NavigateTo<ItemViewModel>();
        }
    }
}
