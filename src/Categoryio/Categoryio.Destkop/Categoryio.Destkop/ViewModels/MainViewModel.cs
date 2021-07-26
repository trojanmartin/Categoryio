using Categoryio.Common.Entities;
using Categoryio.Destkop.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Categoryio.Destkop.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public List<Category> Categories { get; set; }

        public Category SelectedCategory { get; set; }

        public MainViewModel()
        {
            Categories = new List<Category>()
            {
                new Category()
                {
                    Name = "Animals",
                    Created = System.DateTime.Now
                },
                new Category()
                {
                    Name = "World",
                    Created = System.DateTime.Now
                },
                new Category()
                {
                    Name = "Languages",
                    Created = System.DateTime.Now
                }
            };
        }
    }
}
