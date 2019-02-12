using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{

[Table(Name="LOOM.Holyday")]
public partial class Holyday : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<System.DateTime> _date;
	
	private System.Nullable<int> _department;
	
	private int _holydayID;
	
	private EntityRef<Department> _departmentDepartment = new EntityRef<Department>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateChanged();
		
		partial void OnDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDepartmentChanged();
		
		partial void OnDepartmentChanging(System.Nullable<int> value);
		
		partial void OnHolydayIDChanged();
		
		partial void OnHolydayIDChanging(int value);
		#endregion
	
	
	public Holyday()
	{
		this.OnCreated();
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
	
	[Column(Storage="_department", Name="Department", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Department
	{
		get
		{
			return this._department;
		}
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
	
	[Column(Storage="_holydayID", Name="HolydayID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int HolydayID
	{
		get
		{
			return this._holydayID;
		}
		set
		{
			if ((_holydayID != value))
			{
				this.OnHolydayIDChanging(value);
				this.SendPropertyChanging();
				this._holydayID = value;
				this.SendPropertyChanged("HolydayID");
				this.OnHolydayIDChanged();
			}
		}
	}
	
	#region Parents
	[Association(Storage="_departmentDepartment", OtherKey="DepartmentID", ThisKey="Department", Name="HOLYDAY_DEPARTMENTHOLYDAY", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	internal Department DepartmentDepartment
	{
		get
		{
			return this._departmentDepartment.Entity;
		}
		set
		{
			if (((this._departmentDepartment.Entity == value) 
						== false))
			{
				if ((this._departmentDepartment.Entity != null))
				{
					Department previousDepartment = this._departmentDepartment.Entity;
					this._departmentDepartment.Entity = null;
					previousDepartment.HolyDay.Remove(this);
				}
				this._departmentDepartment.Entity = value;
				if ((value != null))
				{
					value.HolyDay.Add(this);
					_department = value.DepartmentID;
				}
				else
				{
					_department = null;
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