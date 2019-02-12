using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{
[Table(Name="LOOM.AbsenceDay")]
public partial class AbsenceDay : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private int _absenceDayID;
	
	private System.Nullable<System.DateTime> _date;
	
	private System.Nullable<int> _staff;
	
	private EntityRef<Staff> _staffStaff = new EntityRef<Staff>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAbsenceDayIDChanged();
		
		partial void OnAbsenceDayIDChanging(int value);
		
		partial void OnDateChanged();
		
		partial void OnDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnStaffChanged();
		
		partial void OnStaffChanging(System.Nullable<int> value);
		#endregion
	
	
	public AbsenceDay()
	{
		this.OnCreated();
	}
	
	[Column(Storage="_absenceDayID", Name="AbsenceDayID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int AbsenceDayID
	{
		get
		{
			return this._absenceDayID;
		}
		set
		{
			if ((_absenceDayID != value))
			{
				this.OnAbsenceDayIDChanging(value);
				this.SendPropertyChanging();
				this._absenceDayID = value;
				this.SendPropertyChanged("AbsenceDayID");
				this.OnAbsenceDayIDChanged();
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
	
	#region Parents
	[Association(Storage="_staffStaff", OtherKey="StaffID", ThisKey="Staff", Name="ABSENCEDAY_STAFFABSENCEDAY", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	internal Staff StaffStaff
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
					previousStaff.AbsenceDay.Remove(this);
				}
				this._staffStaff.Entity = value;
				if ((value != null))
				{
					value.AbsenceDay.Add(this);
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