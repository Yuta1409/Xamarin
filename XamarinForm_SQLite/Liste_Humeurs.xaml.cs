using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForm_SQLite.Models;

namespace XamarinForm_SQLite
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Liste_Humeurs : ContentPage
	{
		public Liste_Humeurs ()
		{
			InitializeComponent ();
		}

        private async void ListeHumeurButton_Clicked(object sender, EventArgs e)
        {

            // Appel de la méthode ListeHumeursAsync de la classe HumeurRepository
            List<Humeur> humeur = await App.HumeurRepository.ListeHumeursAsync();
			ListeHumeur.ItemsSource = humeur;
        }

		private async void ViderButton_Clicked(object sender, EventArgs e)
		{
			await App.HumeurRepository.SupprimerAllHumeurs<Humeur>();
		}

		private async void HumeursListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            // Récupérer l'élément sélectionné
            Humeur humeur = e.Item as Humeur;

                bool alert = await DisplayAlert("Confirmation", "Voulez-vous supprimer cette humeur ?", "Oui", "Non");

                if (alert)
                {
                    // Appel de la méthode SupprimerUneHumeur de la classe HumeurRepository
                    await App.HumeurRepository.SupprimerUneHumeur(humeur);

                    // Rafraîchir la liste des humeurs après la suppression
                    await App.HumeurRepository.ListeHumeursAsync();
                }
            
        }
    }
}