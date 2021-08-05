using Categoryio.Common.Entities;
using Categoryio.Destkop.Base;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Categoryio.Destkop.ViewModels
{
    public class ItemViewModel : BaseViewModel
    {
        public ICommand AddItemCommand => new RelayParametrizedCommand<Item>((item) => AddItem(item));

        public List<Item> Items { get; set; }
        public Item CurrentItem { get;set; }       

        public bool IsCurrentEditable { get; set; }

        public ItemViewModel()
        {
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
                    }
            };
        }

        private void AddItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
