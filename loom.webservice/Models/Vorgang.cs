using System;
using System.Collections.Generic;

namespace loom.time.models
{
    public class Vorgang
    {
        public int VorgangNr { get; set; }

        public string ProjektElementBeschreibung { get; set; }

        public string Projekt { get; set; }

        public int Status { get; set; }

        public string ProzessElementBeschreibung { get; set; }

        public List<Leistung> Leistungen { get; set; }

    }
}


