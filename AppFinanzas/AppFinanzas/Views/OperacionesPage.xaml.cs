using AppFinanzas.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFinanzas.Views
{
    public partial class OperacionesPage : ContentPage
    {
        private readonly OperacionesViewModel viewModel;

        public OperacionesPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new OperacionesViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.OnAppearing();
        }
    }
}