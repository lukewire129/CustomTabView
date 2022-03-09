using System.ComponentModel;
using TabBarCustom.ViewModels;
using Xamarin.Forms;

namespace TabBarCustom.Views
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