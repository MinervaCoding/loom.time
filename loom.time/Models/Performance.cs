using System;

using System.Collections.Generic;

using SQLite;

using SQLiteNetExtensions.Attributes;

namespace loom.time.Models

{

    public class Performance
    {
        [ForeignKey(typeof(Activity))]
        public System.Nullable<int> Activity { get; set; }

        public System.Nullable<System.DateTime> Date { get; set; }

        public System.Nullable<System.DateTime> EntryDate { get; set; }

        [PrimaryKey]
        public int PerformanceID { get; set; }

        [ForeignKey(typeof(Staff))]
        public System.Nullable<int> Staff { get; set; }

        public System.Nullable<decimal> Time { get; set; }

        public System.Nullable<decimal> Work { get; set; }
    }

}