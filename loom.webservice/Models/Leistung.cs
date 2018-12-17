using System;

namespace loom.time.models
{
    public class Leistung
    {
    
        public int LocalLeistungsNr { get; set; }

        //remote primary key
        public int RemoteLeistungsNr { get; set; }

    
        public int VorgangNr { get; set; }

    
        public int PersonalNr { get; set; }

        public DateTime Datum { get; set; }

        public float Stundenleistung { get; set; }

        public float ErzielterFortschritt { get; set; }

        public DateTime Buchungsdatum { get; set; }

        public Vorgang Vorgang { get; set; }

        public Stammdaten Stammdaten { get; set; }
    }
}

