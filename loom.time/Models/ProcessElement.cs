using System;

using System.Collections.Generic;

using SQLite;

using SQLiteNetExtensions.Attributes;

namespace loom.webapi.models
{

	
	public class ProcessElement
		{

		public System.Nullable<int> Department { get; set; }

        public string Description { get; set; }

        public int ProcessElementID { get; set; }

        public System.Nullable<int> ProcessElementType { get; set; }

        public System.Nullable<int> ProcessPhase { get; set; }

    }
}
