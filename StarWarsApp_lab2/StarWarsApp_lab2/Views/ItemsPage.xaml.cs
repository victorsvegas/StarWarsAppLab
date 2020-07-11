using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using StarWarsApp_lab2.Models;
using StarWarsApp_lab2.Views;
using StarWarsApp_lab2.ViewModels;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace StarWarsApp_lab2.Views
{
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();
            BindingContext = App.PeopleModel;
        }
    }
}