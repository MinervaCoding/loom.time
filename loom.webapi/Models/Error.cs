using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{
   

[Table(Name="LOOM.Error")]
public partial class Error : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<int> _activity;
	
	private System.Nullable<int> _errorCode;
	
	private System.Nullable<System.DateTime> _errorDate;
	
	private int _errorID;
	
	private System.Nullable<int> _wastedTime;
	
	private System.Nullable<int> _wastedWork;
	
	private EntityRef<Activity> _activityActivity = new EntityRef<Activity>();
	
	private EntityRef<ErrorCode> _errorCodeErrorCode = new EntityRef<ErrorCode>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActivityChanged();
		
		partial void OnActivityChanging(System.Nullable<int> value);
		
		partial void OnErrorCodeChanged();
		
		partial void OnErrorCodeChanging(System.Nullable<int> value);
		
		partial void OnErrorDateChanged();
		
		partial void OnErrorDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnErrorIDChanged();
		
		partial void OnErrorIDChanging(int value);
		
		partial void OnWastedTimeChanged();
		
		partial void OnWastedTimeChanging(System.Nullable<int> value);
		
		partial void OnWastedWorkChanged();
		
		partial void OnWastedWorkChanging(System.Nullable<int> value);
		#endregion
	
	
	public Error()
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
	
	[Column(Storage="_errorCode", Name="ErrorCode", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> ErrorCode
	{
		get
		{
			return this._errorCode;
		}
		set
		{
			if ((_errorCode != value))
			{
				if (_errorCodeErrorCode.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnErrorCodeChanging(value);
				this.SendPropertyChanging();
				this._errorCode = value;
				this.SendPropertyChanged("ErrorCode");
				this.OnErrorCodeChanged();
			}
		}
	}
	
	[Column(Storage="_errorDate", Name="ErrorDate", DbType="datetime", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<System.DateTime> ErrorDate
	{
		get
		{
			return this._errorDate;
		}
		set
		{
			if ((_errorDate != value))
			{
				this.OnErrorDateChanging(value);
				this.SendPropertyChanging();
				this._errorDate = value;
				this.SendPropertyChanged("ErrorDate");
				this.OnErrorDateChanged();
			}
		}
	}
	
	[Column(Storage="_errorID", Name="ErrorID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int ErrorID
	{
		get
		{
			return this._errorID;
		}
		set
		{
			if ((_errorID != value))
			{
				this.OnErrorIDChanging(value);
				this.SendPropertyChanging();
				this._errorID = value;
				this.SendPropertyChanged("ErrorID");
				this.OnErrorIDChanged();
			}
		}
	}
	
	[Column(Storage="_wastedTime", Name="WastedTime", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> WastedTime
	{
		get
		{
			return this._wastedTime;
		}
		set
		{
			if ((_wastedTime != value))
			{
				this.OnWastedTimeChanging(value);
				this.SendPropertyChanging();
				this._wastedTime = value;
				this.SendPropertyChanged("WastedTime");
				this.OnWastedTimeChanged();
			}
		}
	}
	
	[Column(Storage="_wastedWork", Name="WastedWork", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> WastedWork
	{
		get
		{
			return this._wastedWork;
		}
		set
		{
			if ((_wastedWork != value))
			{
				this.OnWastedWorkChanging(value);
				this.SendPropertyChanging();
				this._wastedWork = value;
				this.SendPropertyChanged("WastedWork");
				this.OnWastedWorkChanged();
			}
		}
	}
	
	#region Parents
	[Association(Storage="_activityActivity", OtherKey="ActivityID", ThisKey="Activity", Name="ERROR_ACTIVITYERROR", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	internal Activity ActivityActivity
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
					previousActivity.Error.Remove(this);
				}
				this._activityActivity.Entity = value;
				if ((value != null))
				{
					value.Error.Add(this);
					_activity = value.ActivityID;
				}
				else
				{
					_activity = null;
				}
			}
		}
	}
	
	[Association(Storage="_errorCodeErrorCode", OtherKey="ErrorCodeID", ThisKey="ErrorCode", Name="ERROR_ERRORCODEERROR", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	internal ErrorCode ErrorCodeErrorCode
	{
		get
		{
			return this._errorCodeErrorCode.Entity;
		}
		set
		{
			if (((this._errorCodeErrorCode.Entity == value) 
						== false))
			{
				if ((this._errorCodeErrorCode.Entity != null))
				{
					ErrorCode previousErrorCode = this._errorCodeErrorCode.Entity;
					this._errorCodeErrorCode.Entity = null;
					previousErrorCode.Error.Remove(this);
				}
				this._errorCodeErrorCode.Entity = value;
				if ((value != null))
				{
					value.Error.Add(this);
					_errorCode = value.ErrorCodeID;
				}
				else
				{
					_errorCode = null;
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