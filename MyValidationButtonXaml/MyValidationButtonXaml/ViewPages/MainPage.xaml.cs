using System;
using MyValidationButtonXaml.ViewModels;
using Xamarin.Forms;

namespace MyValidationButtonXaml.ViewPages
{
    public partial class MainPage : ContentPage
    {
        private UserViewModel _userViewModel;

        public MainPage()
        {
            InitializeComponent();
            _userViewModel = new UserViewModel(false, false);
            Console.WriteLine("User View Model before : " + _userViewModel.IsLastnameValid + "  " + _userViewModel.IsFirstnameValid);
            BindingContext = _userViewModel;
        }

        protected override void OnAppearing()
        {

            Console.WriteLine("[LifeCycle] : OnAppearing trigger");

        }

        private void OnSave(object sender, EventArgs e)
        {
            Console.WriteLine("User View Model : " + _userViewModel.Firstname + "  " + _userViewModel.IsFirstnameValid);
        }
    }
}
