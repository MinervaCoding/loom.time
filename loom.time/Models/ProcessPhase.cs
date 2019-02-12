using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;


namespace loom.time.Models
{

    public class ProcessPhase
    {
        [PrimaryKey]
        public int ProcessPhaseID { get; set; }

        public string Description { get; set; }

    }

}
