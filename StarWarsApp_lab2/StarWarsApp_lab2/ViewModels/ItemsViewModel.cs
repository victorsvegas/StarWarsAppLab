using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using StarWarsApp_lab2.Models;
using StarWarsApp_lab2.Views;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace StarWarsApp_lab2.ViewModels
{
    public class ItemsViewModel
    {
        private ObservableCollection<Models.People> _people = new ObservableCollection<Models.People>();

        public ObservableCollection<Models.People> People
        {
            get
            {
                return this._people;
            }
        }
        
        public async void GetPeople()
        {

            try
            {
                // Gets random person from the star wars api
                Random slumptal = new Random();
                int num = slumptal.Next(0, 87);
                string URL = @"https://swapi.co/api/people/"+num.ToString()+"/?format=json"; 

                HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync(new Uri(URL));

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var peopleList = JsonConvert.DeserializeObject<RootObject>(content);

                    this.People.Add(new People() { name = peopleList.name, height = peopleList.height, mass = peopleList.mass, gender = peopleList.gender, skin_color = peopleList.skin_color, eye_color = peopleList.eye_color, hair_color = peopleList.hair_color, birth_year = peopleList.birth_year });
                }
            }
            catch (Exception ex)
            {
                //ToDo Give errormessage to user and possibly log error
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}