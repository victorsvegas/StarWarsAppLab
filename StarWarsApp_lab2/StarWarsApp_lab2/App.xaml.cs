using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using StarWarsApp_lab2.Services;
using StarWarsApp_lab2.Views;
using StarWarsApp_lab2.ViewModels;

namespace StarWarsApp_lab2
{
    public partial class App : Application
    {
        public static ItemsViewModel PeopleModel { get; set; } = new ItemsViewModel();
        public App()
        {
            InitializeComponent();
            App.PeopleModel.GetPeople();
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
