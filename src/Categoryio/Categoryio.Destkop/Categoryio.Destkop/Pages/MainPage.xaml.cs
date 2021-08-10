using Categoryio.Common.Entities;
using Categoryio.Destkop.IoC;
using Categoryio.Destkop.ViewModels;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Categoryio.Destkop.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public List<Category> Categories { get; set; }
        public MainPage()
        {
            Categories = new List<Category>()
            {
                new Category()
                {
                    Name = "Jazyk a komunikácia",
                    Created = System.DateTime.Now
                },
                new Category()
                {
                    Name = "Matematika a práca s infotmáciami",
                    Created = System.DateTime.Now
                },
                new Category()
                {
                    Name = "Človek a príroda",
                    Created = System.DateTime.Now
                }
            };
            this.InitializeComponent();
            this.DataContext = DIHelper.Resolve<MainViewModel>();
        }
    }
}
