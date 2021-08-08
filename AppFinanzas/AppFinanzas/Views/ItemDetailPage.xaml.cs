using AppFinanzas.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppFinanzas.Views
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