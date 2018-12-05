using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace loom.time
{
    public class Leistung
    {
        [PrimaryKey, AutoIncrement]
        public int LocalLeistungsNr { get; set; }

        //remote primary key
        public int RemoteLeistungsNr { get; set; }

        [ForeignKey(typeof(Vorgang))]
        public int VorgangNr { get; set; }

        [ForeignKey(typeof(Stammdaten))]
        public int PersonalNr { get; set; }

        public DateTime Datum { get; set; }

        public float Stundenleistung { get; set; }

        public float ErzielterFortschritt { get; set; }

        public DateTime Buchungsdatum { get; set; }

        [ManyToOne]      // Many to one relationship with Stock
        public Vorgang Vorgang { get; set; }

        [ManyToOne]      // Many to one relationship with Stock
        public Stammdaten Stammdaten { get; set; }
    }
}

