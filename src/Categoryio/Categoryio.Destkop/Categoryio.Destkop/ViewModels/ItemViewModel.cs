using Categoryio.Common.Entities;
using Categoryio.Destkop.Base;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Categoryio.Destkop.ViewModels
{
    public class ItemViewModel : BaseViewModel
    {
        public ICommand AddItemCommand => new RelayCommand(() => AddItem());
        public ICommand ConfirmItemCommand => new RelayCommand(() => ConfirmItem());
        public ICommand EditItemCommand => new RelayCommand(() => IsCurrentEditable = true);
        public ICommand CancelEditCommand => new RelayCommand(() => IsCurrentEditable = false);
        public ObservableCollection<Item> Items { get; set; }
        public ObservableCollection<Category> Categories { get; set; } = new ObservableCollection<Category>()
        {
            new Category()
            {
                Name = "test category"
            }
        };


        public bool IsSelected => CurrentItem is not null;

        private Item _curentItem;
        public Item CurrentItem
        {
            get => _curentItem;

            set
            {
                _curentItem = value;
                IsCurrentEditable = false;
                OnPropertyChanged();
            }
        }

        private bool _isCurrentEditable = false;
        public bool IsCurrentEditable { get => _isCurrentEditable; set { _isCurrentEditable = value; OnPropertyChanged(); } }

        public ItemViewModel()
        {
            Items = new ObservableCollection<Item>()
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
                    }
            };
        }

        private void AddItem()
        {
            CurrentItem = new Item();
            IsCurrentEditable = true;
        }

        private void ConfirmItem()
        {
            if (CurrentItem.Id == default)
            {
                Items.Add(CurrentItem);
            }
            else
            {
                Items.Remove(Items.FirstOrDefault(x => x.Id == CurrentItem.Id));
                Items.Add(CurrentItem);
            }

            CurrentItem = Items.FirstOrDefault(x => x.Id == CurrentItem.Id);
            IsCurrentEditable = false;
        }
    }
}
