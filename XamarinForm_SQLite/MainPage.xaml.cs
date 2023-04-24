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
            int note;

            if(bonneHumeurRadio.IsChecked)
            {
                note = 1;
            }
            else
            {
                note = 0;
            }
            // Appel de la méthode AjouterHumeurAsync de la classe HumeurRepository
            await App.HumeurRepository.AjouterHumeurAsync(humeurEntry.Text, note,new DateTime() );
        }   
    }
}
