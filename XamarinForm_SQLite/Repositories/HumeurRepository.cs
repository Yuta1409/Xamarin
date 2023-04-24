using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinForm_SQLite.Models;

namespace XamarinForm_SQLite.Repositories
{
    public class HumeurRepository
    {
        protected SQLiteAsyncConnection _connection;

        public HumeurRepository(string dbPath)
        {
            _connection = new SQLiteAsyncConnection(dbPath);
            _connection.CreateTableAsync<Humeur>(); 
        }

        public int nbHumeurs { get; set; }
        public string Message { get; set; }
        public string monHumeur { get; set; }
        public async Task AjouterHumeurAsync(string commentaire, int note, DateTime dateAjout) 
        {
            try
            {
                nbHumeurs = await _connection.InsertAsync(new Humeur { Commentaire = commentaire, Note = note, DateAjout = dateAjout });
                // Gestion d'un message à afficher
                Message = $"Humeur du jour ajoutée : {commentaire}.\n {monHumeur}.\n {dateAjout}";
            }
            catch (Exception e)
            {
                Message = $"Impossible d'ajouter l'humeur : {commentaire}.\n Erreur : {e.Message}";
            }
        }

        

       
    }
}
