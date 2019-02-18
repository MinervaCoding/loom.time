using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{
   
[Table(Name="LOOM.Activity")]
public partial class Activity : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private int _activityID;
	
	private System.Nullable<System.DateTime> _actualEnd;
	
	private System.Nullable<System.DateTime> _actualStart;
	
	private System.Nullable<System.DateTime> _baselineEnd;
	
	private System.Nullable<System.DateTime> _baselineStart;
	
	private string _complexity;
	
	private System.Nullable<int> _processElement;
	
	private System.Nullable<int> _projectElement;
	
	private System.Nullable<int> _status;
	
	private EntitySet<Error> _error;
	
	private EntitySet<Performance> _performance;
	
	private EntitySet<ResourceAllocation> _resourceAllocation;
	
	private EntitySet<PartsListElement> _partsListElement;
	
	private EntityRef<Complexity> _complexityComplexity = new EntityRef<Complexity>();
	
	private EntityRef<ProjectElement> _projectElementProjectElement = new EntityRef<ProjectElement>();
	
	private EntityRef<ProcessElement> _processElementProcessElement = new EntityRef<ProcessElement>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActivityIDChanged();
		
		partial void OnActivityIDChanging(int value);
		
		partial void OnActualEndChanged();
		
		partial void OnActualEndChanging(System.Nullable<System.DateTime> value);
		
		partial void OnActualStartChanged();
		
		partial void OnActualStartChanging(System.Nullable<System.DateTime> value);
		
		partial void OnBaselineEndChanged();
		
		partial void OnBaselineEndChanging(System.Nullable<System.DateTime> value);
		
		partial void OnBaselineStartChanged();
		
		partial void OnBaselineStartChanging(System.Nullable<System.DateTime> value);
		
		partial void OnComplexityChanged();
		
		partial void OnComplexityChanging(string value);
		
		partial void OnProcessElementChanged();
		
		partial void OnProcessElementChanging(System.Nullable<int> value);
		
		partial void OnProjectElementChanged();
		
		partial void OnProjectElementChanging(System.Nullable<int> value);
		
		partial void OnStatusChanged();
		
		partial void OnStatusChanging(System.Nullable<int> value);
		#endregion
	
	
	public Activity()
	{
		_error = new EntitySet<Error>(new Action<Error>(this.Error_Attach), new Action<Error>(this.Error_Detach));
		_performance = new EntitySet<Performance>(new Action<Performance>(this.Performance_Attach), new Action<Performance>(this.Performance_Detach));
		_resourceAllocation = new EntitySet<ResourceAllocation>(new Action<ResourceAllocation>(this.ResourceAllocation_Attach), new Action<ResourceAllocation>(this.ResourceAllocation_Detach));
		_partsListElement = new EntitySet<PartsListElement>(new Action<PartsListElement>(this.PartsListElement_Attach), new Action<PartsListElement>(this.PartsListElement_Detach));
		this.OnCreated();
	}
	
	[Column(Storage="_activityID", Name="ActivityID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.OnInsert, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int ActivityID
	{
		get
		{
			return this._activityID;
		}
		set
		{
			if ((_activityID != value))
			{
				this.OnActivityIDChanging(value);
				this.SendPropertyChanging();
				this._activityID = value;
				this.SendPropertyChanged("ActivityID");
				this.OnActivityIDChanged();
			}
		}
	}
	
	[Column(Storage="_actualEnd", Name="ActualEnd", DbType="datetime", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<System.DateTime> ActualEnd
	{
		get
		{
			return this._actualEnd;
		}
		set
		{
			if ((_actualEnd != value))
			{
				this.OnActualEndChanging(value);
				this.SendPropertyChanging();
				this._actualEnd = value;
				this.SendPropertyChanged("ActualEnd");
				this.OnActualEndChanged();
			}
		}
	}
	
	[Column(Storage="_actualStart", Name="ActualStart", DbType="datetime", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<System.DateTime> ActualStart
	{
		get
		{
			return this._actualStart;
		}
		set
		{
			if ((_actualStart != value))
			{
				this.OnActualStartChanging(value);
				this.SendPropertyChanging();
				this._actualStart = value;
				this.SendPropertyChanged("ActualStart");
				this.OnActualStartChanged();
			}
		}
	}
	
	[Column(Storage="_baselineEnd", Name="BaselineEnd", DbType="datetime", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<System.DateTime> BaselineEnd
	{
		get
		{
			return this._baselineEnd;
		}
		set
		{
			if ((_baselineEnd != value))
			{
				this.OnBaselineEndChanging(value);
				this.SendPropertyChanging();
				this._baselineEnd = value;
				this.SendPropertyChanged("BaselineEnd");
				this.OnBaselineEndChanged();
			}
		}
	}
	
	[Column(Storage="_baselineStart", Name="BaselineStart", DbType="datetime", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<System.DateTime> BaselineStart
	{
		get
		{
			return this._baselineStart;
		}
		set
		{
			if ((_baselineStart != value))
			{
				this.OnBaselineStartChanging(value);
				this.SendPropertyChanging();
				this._baselineStart = value;
				this.SendPropertyChanged("BaselineStart");
				this.OnBaselineStartChanged();
			}
		}
	}
	
	[Column(Storage="_complexity", Name="Complexity", DbType="varchar", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Complexity
	{
		get
		{
			return this._complexity;
		}
		set
		{
			if (((_complexity == value) 
						== false))
			{
				if (_complexityComplexity.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnComplexityChanging(value);
				this.SendPropertyChanging();
				this._complexity = value;
				this.SendPropertyChanged("Complexity");
				this.OnComplexityChanged();
			}
		}
	}
	
	[Column(Storage="_processElement", Name="ProcessElement", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> ProcessElement
	{
		get
		{
			return this._processElement;
		}
		set
		{
			if ((_processElement != value))
			{
				if (_processElementProcessElement.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnProcessElementChanging(value);
				this.SendPropertyChanging();
				this._processElement = value;
				this.SendPropertyChanged("ProcessElement");
				this.OnProcessElementChanged();
			}
		}
	}
	
	[Column(Storage="_projectElement", Name="ProjectElement", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> ProjectElement
	{
		get
		{
			return this._projectElement;
		}
		set
		{
			if ((_projectElement != value))
			{
				if (_projectElementProjectElement.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnProjectElementChanging(value);
				this.SendPropertyChanging();
				this._projectElement = value;
				this.SendPropertyChanged("ProjectElement");
				this.OnProjectElementChanged();
			}
		}
	}
	
	[Column(Storage="_status", Name="Status", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Status
	{
		get
		{
			return this._status;
		}
		set
		{
			if ((_status != value))
			{
				this.OnStatusChanging(value);
				this.SendPropertyChanging();
				this._status = value;
				this.SendPropertyChanged("Status");
				this.OnStatusChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_error", OtherKey="Activity", ThisKey="ActivityID", Name="ERROR_ACTIVITYERROR")]
	[DebuggerNonUserCode()]
	internal EntitySet<Error> Error
	{
		get
		{
			return this._error;
		}
		set
		{
			this._error = value;
		}
	}
	
	[Association(Storage="_performance", OtherKey="Activity", ThisKey="ActivityID", Name="PERFORMANCE_ACTIVITYPERFORMANCE")]
	[DebuggerNonUserCode()]
	internal EntitySet<Performance> Performance
	{
		get
		{
			return this._performance;
		}
		set
		{
			this._performance = value;
		}
	}
	
	[Association(Storage="_resourceAllocation", OtherKey="Activity", ThisKey="ActivityID", Name="RESOURCEALLOCATION_ACTIVITYRESOURCEALLOCATION")]
	[DebuggerNonUserCode()]
	internal EntitySet<ResourceAllocation> ResourceAllocation
	{
		get
		{
			return this._resourceAllocation;
		}
		set
		{
			this._resourceAllocation = value;
		}
	}
	
	[Association(Storage="_partsListElement", OtherKey="Activity", ThisKey="ActivityID", Name="PARTSLISTELEMENT_ACTIVITYPARTSLISTELEMENT")]
	[DebuggerNonUserCode()]
	internal EntitySet<PartsListElement> PartsListElement
	{
		get
		{
			return this._partsListElement;
		}
		set
		{
			this._partsListElement = value;
		}
	}
	#endregion
	
	#region Parents
	[Association(Storage="_complexityComplexity", OtherKey="ComplexityAbc", ThisKey="Complexity", Name="ACTIVITY_COMPLEXITYACTIVITY", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	internal Complexity ComplexityComplexity
	{
		get
		{
			return this._complexityComplexity.Entity;
		}
		set
		{
			if (((this._complexityComplexity.Entity == value) 
						== false))
			{
				if ((this._complexityComplexity.Entity != null))
				{
					Complexity previousComplexity = this._complexityComplexity.Entity;
					this._complexityComplexity.Entity = null;
					previousComplexity.Activity.Remove(this);
				}
				this._complexityComplexity.Entity = value;
				if ((value != null))
				{
					value.Activity.Add(this);
					_complexity = value.ComplexityAbc;
				}
				else
				{
					_complexity = null;
				}
			}
		}
	}
	
	[Association(Storage="_projectElementProjectElement", OtherKey="ProjectElementID", ThisKey="ProjectElement", Name="ACTIVITY_PROJECTELEMENTACTIVITY", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	internal ProjectElement ProjectElementProjectElement
	{
		get
		{
			return this._projectElementProjectElement.Entity;
		}
		set
		{
			if (((this._projectElementProjectElement.Entity == value) 
						== false))
			{
				if ((this._projectElementProjectElement.Entity != null))
				{
					ProjectElement previousProjectElement = this._projectElementProjectElement.Entity;
					this._projectElementProjectElement.Entity = null;
					previousProjectElement.Activity.Remove(this);
				}
				this._projectElementProjectElement.Entity = value;
				if ((value != null))
				{
					value.Activity.Add(this);
					_projectElement = value.ProjectElementID;
				}
				else
				{
					_projectElement = null;
				}
			}
		}
	}
	
	[Association(Storage="_processElementProcessElement", OtherKey="ProcessElementID", ThisKey="ProcessElement", Name="ACTIVITY_PROCESSELEMENTACTIVITY", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	internal ProcessElement ProcessElementProcessElement
	{
		get
		{
			return this._processElementProcessElement.Entity;
		}
		set
		{
			if (((this._processElementProcessElement.Entity == value) 
						== false))
			{
				if ((this._processElementProcessElement.Entity != null))
				{
					ProcessElement previousProcessElement = this._processElementProcessElement.Entity;
					this._processElementProcessElement.Entity = null;
					previousProcessElement.Activity.Remove(this);
				}
				this._processElementProcessElement.Entity = value;
				if ((value != null))
				{
					value.Activity.Add(this);
					_processElement = value.ProcessElementID;
				}
				else
				{
					_processElement = null;
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
	private void Error_Attach(Error entity)
	{
		this.SendPropertyChanging();
		entity.ActivityActivity = this;
	}
	
	private void Error_Detach(Error entity)
	{
		this.SendPropertyChanging();
		entity.ActivityActivity = null;
	}
	
	private void Performance_Attach(Performance entity)
	{
		this.SendPropertyChanging();
		entity.ActivityActivity = this;
	}
	
	private void Performance_Detach(Performance entity)
	{
		this.SendPropertyChanging();
		entity.ActivityActivity = null;
	}
	
	private void ResourceAllocation_Attach(ResourceAllocation entity)
	{
		this.SendPropertyChanging();
		entity.ActivityActivity = this;
	}
	
	private void ResourceAllocation_Detach(ResourceAllocation entity)
	{
		this.SendPropertyChanging();
		entity.ActivityActivity = null;
	}
	
	private void PartsListElement_Attach(PartsListElement entity)
	{
		this.SendPropertyChanging();
		entity.ActivityActivity = this;
	}
	
	private void PartsListElement_Detach(PartsListElement entity)
	{
		this.SendPropertyChanging();
		entity.ActivityActivity = null;
	}
	#endregion
}

}