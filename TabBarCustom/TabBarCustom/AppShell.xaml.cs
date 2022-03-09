using System;
using System.Collections.Generic;
using TabBarCustom.ViewModels;
using TabBarCustom.Views;
using Xamarin.Forms;

namespace TabBarCustom
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
