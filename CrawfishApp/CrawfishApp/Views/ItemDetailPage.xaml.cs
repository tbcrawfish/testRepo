using System.ComponentModel;
using Xamarin.Forms;
using CrawfishApp.ViewModels;

namespace CrawfishApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
