using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace loom.webapi.models
{

    public class ProjectElement {

        public string Comment { get; set; }


        public System.Nullable<int> CountryOfExecution { get; set; }


        public System.Nullable<System.DateTime> CreationDate { get; set; }


        public string Description { get; set; }


        public System.Nullable<int> PerEsponsible { get; set; }


        public System.Nullable<int> Predecessor { get; set; }


        public int ProjectElementID { get; set; }


        public System.Nullable<int> ProjectElementType { get; set; }


        public System.Nullable<decimal> ProjectNumber { get; set; }


        public System.Nullable<int> Subsidiary { get; set; }
    }

}