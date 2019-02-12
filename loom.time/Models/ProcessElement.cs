using System;

using System.Collections.Generic;

using SQLite;

using SQLiteNetExtensions.Attributes;

namespace loom.time.Models
{


    public class ProcessElement
    {
        [ForeignKey(typeof(Department))]
        public System.Nullable<int> Department { get; set; }

        public string Description { get; set; }

        [PrimaryKey]
        public int ProcessElementID { get; set; }

        public System.Nullable<int> ProcessElementType { get; set; }

        [ForeignKey(typeof(ProcessPhase))]
        public System.Nullable<int> ProcessPhase { get; set; }

        [ManyToOne]
        public Activity Activities { get; set; }


    }
}
