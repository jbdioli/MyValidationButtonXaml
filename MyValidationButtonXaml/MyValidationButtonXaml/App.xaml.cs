using System;
using MyValidationButtonXaml.ViewPages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyValidationButtonXaml
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
