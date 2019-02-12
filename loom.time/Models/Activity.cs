
using System;

using System.Collections.Generic;

using SQLite;

using SQLiteNetExtensions.Attributes;

namespace loom.time.Models
{

    public class Activity
    {
        [PrimaryKey]
        public int ActivityID { get; set; }

        public System.Nullable<System.DateTime> ActualEnd { get; set; }

        public System.Nullable<System.DateTime> ActualStart { get; set; }

        public System.Nullable<System.DateTime> BaselineEnd { get; set; }

        public System.Nullable<System.DateTime> BaselineStart { get; set; }

        public string Complexity { get; set; }

        [ForeignKey(typeof(ProcessElement))]
        public System.Nullable<int> ProcessElement { get; set; }

        [ForeignKey(typeof(ProjectElement))]
        public System.Nullable<int> ProjectElement { get; set; }

        public System.Nullable<int> Status { get; set; }

        [ManyToOne]      // Many to one relationship with Performance
        public Performance Performances { get; set; }

    }
}