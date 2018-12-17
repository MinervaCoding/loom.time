using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace loom.time.models
{
    public class Stammdaten
    {
        [PrimaryKey]
        public int PersonalNr { get; set; }

        public string Vorname { get; set; }

        public string Name { get; set; }

        public string Abteilung { get; set; }

        public int AbteilungsNr { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]      // One to many relationship with Valuation
        public List<Leistung> Leistungen { get; set; }

    }
}


