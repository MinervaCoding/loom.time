using System;

using System.Collections.Generic;

using SQLite;

using SQLiteNetExtensions.Attributes;

namespace loom.time.Models
{

    public class Staff
    {
        [ForeignKey(typeof(Department))]
        public System.Nullable<int> Department { get; set; }

        public string FirstName { get; set; }

        public System.Nullable<int> HoursPerWeek { get; set; }

        public string LastName { get; set; }

        public System.Nullable<int> Skill { get; set; }

        [PrimaryKey]
        public int StaffID { get; set; }

        public string WindowsUser { get; set; }

        [ManyToOne]
        public ProjectElement ProjectElements { get; set; }

    }
}
