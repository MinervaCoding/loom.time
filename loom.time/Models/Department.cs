using System;

using System.Collections.Generic;

using SQLite;

using SQLiteNetExtensions.Attributes;

namespace loom.time.Models
{

    public class Department
    {

        public System.Nullable<int> CostCenter { get; set; }

        [PrimaryKey]
        public int DepartmentID { get; set; }

        public string Description { get; set; }

        [ManyToOne]      // Many to one relationship with Staff
        public Staff Staff { get; set; }

        [ManyToOne]      // Many to one relationship with ProcessElement
        public ProcessElement ProcessElements { get; set; }

    }
}