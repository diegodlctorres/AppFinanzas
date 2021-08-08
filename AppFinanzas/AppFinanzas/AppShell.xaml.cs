using AppFinanzas.ViewModels;
using AppFinanzas.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppFinanzas
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(OperacionesPage), typeof(OperacionesPage));
        }

    }
}
