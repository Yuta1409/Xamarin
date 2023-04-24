using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace XamarinForm_SQLite.Models
{

    [Table("Humeur")]
    public class Humeur
    {
        [PrimaryKey,  AutoIncrement]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Commentaire { get; set; }

        public int Note { get; set; }

        public DateTime DateAjout { get; set; }
    }
}
