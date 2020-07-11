using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace StarWarsApp_lab2.ViewModels
{
    public class AboutViewModel
    {
        public AboutViewModel()
        {
            //Title = "About Star Wars";

            OpenWebCommand1 = new Command(() => Device.OpenUri(new Uri("https://www.starwars.com/")));
            OpenWebCommand2 = new Command(() => Device.OpenUri(new Uri("https://swapi.co/")));
        }

        public ICommand OpenWebCommand1 { get; }
        public ICommand OpenWebCommand2 { get; }
    }
}