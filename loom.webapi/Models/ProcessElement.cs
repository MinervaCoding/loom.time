using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{

	[Table(Name = "LOOM.ProcessElement")]
	public partial class ProcessElement : System.ComponentModel.INotifyPropertyChanging,
		System.ComponentModel.INotifyPropertyChanged
	{

		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs =
			new System.ComponentModel.PropertyChangingEventArgs("");

		private System.Nullable<int> _department;

		private string _description;

		private int _processElementID;

		private System.Nullable<int> _processElementType;

		private System.Nullable<int> _processPhase;

		private EntitySet<PERelation> _PERelationPredecessor;
		
		private EntitySet<PERelation> _PERelationSuccessor;

		private EntitySet<Activity> _activity;

		private EntitySet<TargetTime> _targetTime;

		private EntityRef<Department> _departmentDepartment = new EntityRef<Department>();

		private EntityRef<ProcessElementType> _processElementTypeProcessElementType =
			new EntityRef<ProcessElementType>();

		private EntityRef<ProcessPhase> _processPhaseProcessPhase = new EntityRef<ProcessPhase>();

		#region Extensibility Method Declarations

		partial void OnCreated();

		partial void OnDepartmentChanged();

		partial void OnDepartmentChanging(System.Nullable<int> value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnProcessElementIDChanged();

		partial void OnProcessElementIDChanging(int value);

		partial void OnProcessElementTypeChanged();

		partial void OnProcessElementTypeChanging(System.Nullable<int> value);

		partial void OnProcessPhaseChanged();

		partial void OnProcessPhaseChanging(System.Nullable<int> value);

		#endregion


		public ProcessElement()
		{
			_PERelationPredecessor = new EntitySet<PERelation>(new Action<PERelation>(this.PERelationPredecessor_Attach),
				new Action<PERelation>(this.PERelationPredecessor_Detach));
			_PERelationSuccessor = new EntitySet<PERelation>(new Action<PERelation>(this.PERelationSuccessor_Attach),
				new Action<PERelation>(this.PERelationSuccessor_Detach));
			_activity = new EntitySet<Activity>(new Action<Activity>(this.Activity_Attach),
				new Action<Activity>(this.Activity_Detach));
			_targetTime = new EntitySet<TargetTime>(new Action<TargetTime>(this.TargetTime_Attach),
				new Action<TargetTime>(this.TargetTime_Detach));
			this.OnCreated();
		}

		[Column(Storage = "_department", Name = "Department", DbType = "int", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Department
		{
			get { return this._department; }
			set
			{
				if ((_department != value))
				{
					if (_departmentDepartment.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}

					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "Description", DbType = "varchar", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get { return this._description; }
			set
			{
				if (((_description == value)
				     == false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_processElementID", Name = "ProcessElementID", DbType = "int", IsPrimaryKey = true,
			IsDbGenerated = true, AutoSync = AutoSync.OnInsert, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public int ProcessElementID
		{
			get { return this._processElementID; }
			set
			{
				if ((_processElementID != value))
				{
					this.OnProcessElementIDChanging(value);
					this.SendPropertyChanging();
					this._processElementID = value;
					this.SendPropertyChanged("ProcessElementID");
					this.OnProcessElementIDChanged();
				}
			}
		}

		[Column(Storage = "_processElementType", Name = "ProcessElementType", DbType = "int",
			AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ProcessElementType
		{
			get { return this._processElementType; }
			set
			{
				if ((_processElementType != value))
				{
					if (_processElementTypeProcessElementType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}

					this.OnProcessElementTypeChanging(value);
					this.SendPropertyChanging();
					this._processElementType = value;
					this.SendPropertyChanged("ProcessElementType");
					this.OnProcessElementTypeChanged();
				}
			}
		}

		[Column(Storage = "_processPhase", Name = "ProcessPhase", DbType = "int", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ProcessPhase
		{
			get { return this._processPhase; }
			set
			{
				if ((_processPhase != value))
				{
					if (_processPhaseProcessPhase.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}

					this.OnProcessPhaseChanging(value);
					this.SendPropertyChanging();
					this._processPhase = value;
					this.SendPropertyChanged("ProcessPhase");
					this.OnProcessPhaseChanged();
				}
			}
		}

		#region Children

		[Association(Storage = "_PERelationPredecessor", OtherKey = "PEPredecessor", ThisKey = "ProcessElementID",
			Name = "PROCESSELEMENT_PERELATION_PREDECESSOR")]
		[DebuggerNonUserCode()]
		internal EntitySet<PERelation> PERelationPredecessor
		{
			get { return this._PERelationPredecessor; }
			set { this._PERelationPredecessor = value; }
		}
		
		[Association(Storage = "_PERelationSuccessor", OtherKey = "PESuccessor", ThisKey = "ProcessElementID",
			Name = "PROCESSELEMENT_PERELATION_SUCCESSOR")]
		[DebuggerNonUserCode()]
		internal EntitySet<PERelation> PERelationSuccessor
		{
			get { return this._PERelationSuccessor; }
			set { this._PERelationSuccessor = value; }
		}
		
		[Association(Storage = "_activity", OtherKey = "ProcessElement", ThisKey = "ProcessElementID",
			Name = "ACTIVITY_PROCESSELEMENTACTIVITY")]
		[DebuggerNonUserCode()]
		internal EntitySet<Activity> Activity
		{
			get { return this._activity; }
			set { this._activity = value; }
		}

		[Association(Storage = "_targetTime", OtherKey = "ProcessElement", ThisKey = "ProcessElementID",
			Name = "TARGETTIME_PROCESSELEMENTTARGETTIME")]
		[DebuggerNonUserCode()]
		internal EntitySet<TargetTime> TargetTime
		{
			get { return this._targetTime; }
			set { this._targetTime = value; }
		}

		#endregion

		#region Parents

		[Association(Storage = "_departmentDepartment", OtherKey = "DepartmentID", ThisKey = "Department",
			Name = "PROCESSELEMENT_DEPARTMENTPROCESSELEMENT", IsForeignKey = true)]
		[DebuggerNonUserCode()]
		internal Department DepartmentDepartment
		{
			get { return this._departmentDepartment.Entity; }
			set
			{
				if (((this._departmentDepartment.Entity == value)
				     == false))
				{
					if ((this._departmentDepartment.Entity != null))
					{
						Department previousDepartment = this._departmentDepartment.Entity;
						this._departmentDepartment.Entity = null;
						previousDepartment.ProcessElement.Remove(this);
					}

					this._departmentDepartment.Entity = value;
					if ((value != null))
					{
						value.ProcessElement.Add(this);
						_department = value.DepartmentID;
					}
					else
					{
						_department = null;
					}
				}
			}
		}

		[Association(Storage = "_processElementTypeProcessElementType", OtherKey = "ProcessElementTypeID",
			ThisKey = "ProcessElementType", Name = "PROCESSELEMENT_PROCESSELEMENTTYPEPROCESSELEMENT",
			IsForeignKey = true)]
		[DebuggerNonUserCode()]
		internal ProcessElementType ProcessElementTypeProcessElementType
		{
			get { return this._processElementTypeProcessElementType.Entity; }
			set
			{
				if (((this._processElementTypeProcessElementType.Entity == value)
				     == false))
				{
					if ((this._processElementTypeProcessElementType.Entity != null))
					{
						ProcessElementType previousProcessElementType =
							this._processElementTypeProcessElementType.Entity;
						this._processElementTypeProcessElementType.Entity = null;
						previousProcessElementType.ProcessElement.Remove(this);
					}

					this._processElementTypeProcessElementType.Entity = value;
					if ((value != null))
					{
						value.ProcessElement.Add(this);
						_processElementType = value.ProcessElementTypeID;
					}
					else
					{
						_processElementType = null;
					}
				}
			}
		}

		[Association(Storage = "_processPhaseProcessPhase", OtherKey = "ProcessPhaseID", ThisKey = "ProcessPhase",
			Name = "PROCESSELEMENT_PROCESSPHASEPROCESSELEMENT", IsForeignKey = true)]
		[DebuggerNonUserCode()]
		internal ProcessPhase ProcessPhaseProcessPhase
		{
			get { return this._processPhaseProcessPhase.Entity; }
			set
			{
				if (((this._processPhaseProcessPhase.Entity == value)
				     == false))
				{
					if ((this._processPhaseProcessPhase.Entity != null))
					{
						ProcessPhase previousProcessPhase = this._processPhaseProcessPhase.Entity;
						this._processPhaseProcessPhase.Entity = null;
						previousProcessPhase.ProcessElement.Remove(this);
					}

					this._processPhaseProcessPhase.Entity = value;
					if ((value != null))
					{
						value.ProcessElement.Add(this);
						_processPhase = value.ProcessPhaseID;
					}
					else
					{
						_processPhase = null;
					}
				}
			}
		}

		#endregion

		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}

		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		#region Attachment handlers

		private void PERelationPredecessor_Attach(PERelation entity)
		{
			this.SendPropertyChanging();
			entity.ProcessElementPredecessor = this;
		}

		private void PERelationPredecessor_Detach(PERelation entity)
		{
			this.SendPropertyChanging();
			entity.ProcessElementPredecessor = null;
		}
		
		private void PERelationSuccessor_Attach(PERelation entity)
		{
			this.SendPropertyChanging();
			entity.ProcessElementSuccessor = this;
		}

		private void PERelationSuccessor_Detach(PERelation entity)
		{
			this.SendPropertyChanging();
			entity.ProcessElementSuccessor = null;
		}

		private void Activity_Attach(Activity entity)
		{
			this.SendPropertyChanging();
			entity.ProcessElementProcessElement = this;
		}

		private void Activity_Detach(Activity entity)
		{
			this.SendPropertyChanging();
			entity.ProcessElementProcessElement = null;
		}

		private void TargetTime_Attach(TargetTime entity)
		{
			this.SendPropertyChanging();
			entity.ProcessElementProcessElement = this;
		}

		private void TargetTime_Detach(TargetTime entity)
		{
			this.SendPropertyChanging();
			entity.ProcessElementProcessElement = null;
		}

		#endregion
	}
}
