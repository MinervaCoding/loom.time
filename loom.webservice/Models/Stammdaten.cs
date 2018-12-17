using System;
using System.Collections.Generic;

namespace loom.time.models
{
    public class Stammdaten
    {
        public int PersonalNr { get; set; }

        public string Vorname { get; set; }

        public string Name { get; set; }

        public string Abteilung { get; set; }

        public int AbteilungsNr { get; set; }

        public List<Leistung> Leistungen { get; set; }

    }
}


