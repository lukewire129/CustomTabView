using System;
using System.Collections.Generic;
using System.ComponentModel;
using TabBarCustom.Models;
using TabBarCustom.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabBarCustom.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}