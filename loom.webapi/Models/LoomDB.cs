using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models

{
	public partial class LoomDB : DataContext
	{

		#region Extensibility Method Declarations

		partial void OnCreated();

		#endregion


		public LoomDB(string connectionString) :
			base(connectionString)
		{
			this.OnCreated();
		}

		public LoomDB(IDbConnection connection) :
			base(connection)
		{
			this.OnCreated();
		}

		public LoomDB(string connection, MappingSource mappingSource) :
			base(connection, mappingSource)
		{
			this.OnCreated();
		}

		public LoomDB(IDbConnection connection, MappingSource mappingSource) :
			base(connection, mappingSource)
		{
			this.OnCreated();
		}

		public Table<AbsenceDay> AbsenceDay
		{
			get { return this.GetTable<AbsenceDay>(); }
		}

		public Table<Activity> Activity
		{
			get { return this.GetTable<Activity>(); }
		}

		public Table<Complexity> Complexity
		{
			get { return this.GetTable<Complexity>(); }
		}

		public Table<Country> Country
		{
			get { return this.GetTable<Country>(); }
		}

		public Table<Department> Department
		{
			get { return this.GetTable<Department>(); }
		}

		public Table<Error> Error
		{
			get { return this.GetTable<Error>(); }
		}

		public Table<ErrorCode> ErrorCode
		{
			get { return this.GetTable<ErrorCode>(); }
		}

		public Table<Holyday> Holyday
		{
			get { return this.GetTable<Holyday>(); }
		}

		public Table<PartsListElement> PartsListElement
		{
			get { return this.GetTable<PartsListElement>(); }
		}

		public Table<PERelation> PerElation
		{
			get { return this.GetTable<PERelation>(); }
		}

		public Table<Performance> Performance
		{
			get { return this.GetTable<Performance>(); }
		}

		public Table<PPL> PPL
		{
			get { return this.GetTable<PPL>(); }
		}

		public Table<ProcessElement> ProcessElement
		{
			get { return this.GetTable<ProcessElement>(); }
		}

		public Table<ProcessElementType> ProcessElementType
		{
			get { return this.GetTable<ProcessElementType>(); }
		}

		public Table<ProcessPhase> ProcessPhase
		{
			get { return this.GetTable<ProcessPhase>(); }
		}

		public Table<ProjectElement> ProjectElement
		{
			get { return this.GetTable<ProjectElement>(); }
		}

		public Table<ProjectElementType> ProjectElementType
		{
			get { return this.GetTable<ProjectElementType>(); }
		}

		public Table<QuantityUnit> QuantityUnit
		{
			get { return this.GetTable<QuantityUnit>(); }
		}

		public Table<QuantityUnitKey> QuantityUnitKey
		{
			get { return this.GetTable<QuantityUnitKey>(); }
		}

		public Table<ReferenceQuantity> ReferenceQuantity
		{
			get { return this.GetTable<ReferenceQuantity>(); }
		}

		public Table<ResourceAllocation> ResourceAllocation
		{
			get { return this.GetTable<ResourceAllocation>(); }
		}

		public Table<Staff> Staff
		{
			get { return this.GetTable<Staff>(); }
		}

		public Table<Subsidiary> Subsidiary
		{
			get { return this.GetTable<Subsidiary>(); }
		}

		public Table<TargetTime> TargetTime
		{
			get { return this.GetTable<TargetTime>(); }
		}
	}
}