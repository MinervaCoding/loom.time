using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{
    
[Table(Name="LOOM.ResourceAllocation")]
public partial class ResourceAllocation : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<int> _activity;
	
	private System.Nullable<int> _duration;
	
	private System.Nullable<int> _intensity;
	
	private int _resourceAllocationID;
	
	private System.Nullable<int> _role;
	
	private System.Nullable<int> _staff;
	
	private System.Nullable<System.DateTime> _start;
	
	private EntityRef<Activity> _activityActivity = new EntityRef<Activity>();
	
	private EntityRef<Staff> _staffStaff = new EntityRef<Staff>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActivityChanged();
		
		partial void OnActivityChanging(System.Nullable<int> value);
		
		partial void OnDurationChanged();
		
		partial void OnDurationChanging(System.Nullable<int> value);
		
		partial void OnIntensityChanged();
		
		partial void OnIntensityChanging(System.Nullable<int> value);
		
		partial void OnResourceAllocationIDChanged();
		
		partial void OnResourceAllocationIDChanging(int value);
		
		partial void OnRoleChanged();
		
		partial void OnRoleChanging(System.Nullable<int> value);
		
		partial void OnStaffChanged();
		
		partial void OnStaffChanging(System.Nullable<int> value);
		
		partial void OnStartChanged();
		
		partial void OnStartChanging(System.Nullable<System.DateTime> value);
		#endregion
	
	
	public ResourceAllocation()
	{
		this.OnCreated();
	}
	
	[Column(Storage="_activity", Name="Activity", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Activity
	{
		get
		{
			return this._activity;
		}
		set
		{
			if ((_activity != value))
			{
				if (_activityActivity.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnActivityChanging(value);
				this.SendPropertyChanging();
				this._activity = value;
				this.SendPropertyChanged("Activity");
				this.OnActivityChanged();
			}
		}
	}
	
	[Column(Storage="_duration", Name="Duration", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Duration
	{
		get
		{
			return this._duration;
		}
		set
		{
			if ((_duration != value))
			{
				this.OnDurationChanging(value);
				this.SendPropertyChanging();
				this._duration = value;
				this.SendPropertyChanged("Duration");
				this.OnDurationChanged();
			}
		}
	}
	
	[Column(Storage="_intensity", Name="Intensity", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Intensity
	{
		get
		{
			return this._intensity;
		}
		set
		{
			if ((_intensity != value))
			{
				this.OnIntensityChanging(value);
				this.SendPropertyChanging();
				this._intensity = value;
				this.SendPropertyChanged("Intensity");
				this.OnIntensityChanged();
			}
		}
	}
	
	[Column(Storage="_resourceAllocationID", Name="ResourceAllocationID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int ResourceAllocationID
	{
		get
		{
			return this._resourceAllocationID;
		}
		set
		{
			if ((_resourceAllocationID != value))
			{
				this.OnResourceAllocationIDChanging(value);
				this.SendPropertyChanging();
				this._resourceAllocationID = value;
				this.SendPropertyChanged("ResourceAllocationID");
				this.OnResourceAllocationIDChanged();
			}
		}
	}
	
	[Column(Storage="_role", Name="Role", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Role
	{
		get
		{
			return this._role;
		}
		set
		{
			if ((_role != value))
			{
				this.OnRoleChanging(value);
				this.SendPropertyChanging();
				this._role = value;
				this.SendPropertyChanged("Role");
				this.OnRoleChanged();
			}
		}
	}
	
	[Column(Storage="_staff", Name="Staff", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Staff
	{
		get
		{
			return this._staff;
		}
		set
		{
			if ((_staff != value))
			{
				if (_staffStaff.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnStaffChanging(value);
				this.SendPropertyChanging();
				this._staff = value;
				this.SendPropertyChanged("Staff");
				this.OnStaffChanged();
			}
		}
	}
	
	[Column(Storage="_start", Name="Start", DbType="datetime", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<System.DateTime> Start
	{
		get
		{
			return this._start;
		}
		set
		{
			if ((_start != value))
			{
				this.OnStartChanging(value);
				this.SendPropertyChanging();
				this._start = value;
				this.SendPropertyChanged("Start");
				this.OnStartChanged();
			}
		}
	}
	
	#region Parents
	[Association(Storage="_activityActivity", OtherKey="ActivityID", ThisKey="Activity", Name="RESOURCEALLOCATION_ACTIVITYRESOURCEALLOCATION", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public Activity ActivityActivity
	{
		get
		{
			return this._activityActivity.Entity;
		}
		set
		{
			if (((this._activityActivity.Entity == value) 
						== false))
			{
				if ((this._activityActivity.Entity != null))
				{
					Activity previousActivity = this._activityActivity.Entity;
					this._activityActivity.Entity = null;
					previousActivity.ResourceAllocation.Remove(this);
				}
				this._activityActivity.Entity = value;
				if ((value != null))
				{
					value.ResourceAllocation.Add(this);
					_activity = value.ActivityID;
				}
				else
				{
					_activity = null;
				}
			}
		}
	}
	
	[Association(Storage="_staffStaff", OtherKey="StaffID", ThisKey="Staff", Name="RESOURCEALLOCATION_STAFFRESOURCEALLOCATION", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public Staff StaffStaff
	{
		get
		{
			return this._staffStaff.Entity;
		}
		set
		{
			if (((this._staffStaff.Entity == value) 
						== false))
			{
				if ((this._staffStaff.Entity != null))
				{
					Staff previousStaff = this._staffStaff.Entity;
					this._staffStaff.Entity = null;
					previousStaff.ResourceAllocation.Remove(this);
				}
				this._staffStaff.Entity = value;
				if ((value != null))
				{
					value.ResourceAllocation.Add(this);
					_staff = value.StaffID;
				}
				else
				{
					_staff = null;
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
}

}