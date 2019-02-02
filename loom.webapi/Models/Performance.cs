using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{
    
[Table(Name="LOOM.Performance")]
public partial class Performance : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<int> _activity;
	
	private System.Nullable<System.DateTime> _date;
	
	private System.Nullable<System.DateTime> _entryDate;
	
	private int _performanceID;
	
	private System.Nullable<int> _staff;
	
	private System.Nullable<decimal> _time;
	
	private System.Nullable<decimal> _work;
	
	private EntityRef<Activity> _activityActivity = new EntityRef<Activity>();
	
	private EntityRef<Staff> _staffStaff = new EntityRef<Staff>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActivityChanged();
		
		partial void OnActivityChanging(System.Nullable<int> value);
		
		partial void OnDateChanged();
		
		partial void OnDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnEntryDateChanged();
		
		partial void OnEntryDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnPerformanceIDChanged();
		
		partial void OnPerformanceIDChanging(int value);
		
		partial void OnStaffChanged();
		
		partial void OnStaffChanging(System.Nullable<int> value);
		
		partial void OnTimeChanged();
		
		partial void OnTimeChanging(System.Nullable<decimal> value);
		
		partial void OnWorkChanged();
		
		partial void OnWorkChanging(System.Nullable<decimal> value);
		#endregion
	
	
	public Performance()
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
	
	[Column(Storage="_date", Name="Date", DbType="datetime", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<System.DateTime> Date
	{
		get
		{
			return this._date;
		}
		set
		{
			if ((_date != value))
			{
				this.OnDateChanging(value);
				this.SendPropertyChanging();
				this._date = value;
				this.SendPropertyChanged("Date");
				this.OnDateChanged();
			}
		}
	}
	
	[Column(Storage="_entryDate", Name="EntryDate", DbType="datetime", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<System.DateTime> EntryDate
	{
		get
		{
			return this._entryDate;
		}
		set
		{
			if ((_entryDate != value))
			{
				this.OnEntryDateChanging(value);
				this.SendPropertyChanging();
				this._entryDate = value;
				this.SendPropertyChanged("EntryDate");
				this.OnEntryDateChanged();
			}
		}
	}
	
	[Column(Storage="_performanceID", Name="PerformanceID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int PerformanceID
	{
		get
		{
			return this._performanceID;
		}
		set
		{
			if ((_performanceID != value))
			{
				this.OnPerformanceIDChanging(value);
				this.SendPropertyChanging();
				this._performanceID = value;
				this.SendPropertyChanged("PerformanceID");
				this.OnPerformanceIDChanged();
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
	
	[Column(Storage="_time", Name="Time", DbType="decimal", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<decimal> Time
	{
		get
		{
			return this._time;
		}
		set
		{
			if ((_time != value))
			{
				this.OnTimeChanging(value);
				this.SendPropertyChanging();
				this._time = value;
				this.SendPropertyChanged("Time");
				this.OnTimeChanged();
			}
		}
	}
	
	[Column(Storage="_work", Name="Work", DbType="decimal", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<decimal> Work
	{
		get
		{
			return this._work;
		}
		set
		{
			if ((_work != value))
			{
				this.OnWorkChanging(value);
				this.SendPropertyChanging();
				this._work = value;
				this.SendPropertyChanged("Work");
				this.OnWorkChanged();
			}
		}
	}
	
	#region Parents
	[Association(Storage="_activityActivity", OtherKey="ActivityID", ThisKey="Activity", Name="PERFORMANCE_ACTIVITYPERFORMANCE", IsForeignKey=true)]
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
					previousActivity.Performance.Remove(this);
				}
				this._activityActivity.Entity = value;
				if ((value != null))
				{
					value.Performance.Add(this);
					_activity = value.ActivityID;
				}
				else
				{
					_activity = null;
				}
			}
		}
	}
	
	[Association(Storage="_staffStaff", OtherKey="StaffID", ThisKey="Staff", Name="PERFORMANCE_STAFFPERFORMANCE", IsForeignKey=true)]
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
					previousStaff.Performance.Remove(this);
				}
				this._staffStaff.Entity = value;
				if ((value != null))
				{
					value.Performance.Add(this);
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