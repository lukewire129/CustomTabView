using System;
using TabBarCustom.Services;
using TabBarCustom.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabBarCustom
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
