using Categoryio.Destkop.IoC;
using Categoryio.Destkop.ViewModels;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Categoryio.Destkop.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ItemPage : Page
    {
        public ItemViewModel ViewModel { get; set; }
        
        public ItemPage()
        {            
            this.InitializeComponent();            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ViewModel = DIHelper.Resolve<ItemViewModel>();
            this.DataContext = ViewModel;
        }
    }
}
