using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace loom.time.Models
{
    public class Vorgang
    {
        [PrimaryKey]
        public int VorgangNr { get; set; }

        public string ProjektElementBeschreibung { get; set; }

        public string Projekt { get; set; }

        public int Status { get; set; }

        public string ProzessElementBeschreibung { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]      // One to many relationship with Valuation
        public List<Leistung> Leistungen { get; set; }

    }
}


