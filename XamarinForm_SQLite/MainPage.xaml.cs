using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinForm_SQLite.Repositories;

namespace XamarinForm_SQLite
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void HumeurButton_Clicked(object sender, EventArgs e)
        {
            bool action = await DisplayAlert("Félicitation !", "Votre humeur à bien été ajouter à la liste.", "OUI", "NON");

            if (action)
            {
                // Appel de la méthode AjouterHumeurAsync de la classe HumeurRepository
                await App.HumeurRepository.AjouterHumeurAsync(humeurEntry.Text, bonneHumeurRadio.IsChecked ? 1 : 0, DateTime.Now);
            }

            
        }   
    }
}
