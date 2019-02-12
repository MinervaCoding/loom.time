using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{


[Table(Name="LOOM.Department")]
public partial class Department : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<int> _costCenter;
	
	private int _departmentID;
	
	private string _description;
	
	private EntitySet<Holyday> _holyDay;
	
	private EntitySet<Staff> _staff;
	
	private EntitySet<ProcessElement> _processElement;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCostCenterChanged();
		
		partial void OnCostCenterChanging(System.Nullable<int> value);
		
		partial void OnDepartmentIDChanged();
		
		partial void OnDepartmentIDChanging(int value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		#endregion
	
	
	public Department()
	{
		_holyDay = new EntitySet<Holyday>(new Action<Holyday>(this.HolyDay_Attach), new Action<Holyday>(this.HolyDay_Detach));
		_staff = new EntitySet<Staff>(new Action<Staff>(this.Staff_Attach), new Action<Staff>(this.Staff_Detach));
		_processElement = new EntitySet<ProcessElement>(new Action<ProcessElement>(this.ProcessElement_Attach), new Action<ProcessElement>(this.ProcessElement_Detach));
		this.OnCreated();
	}
	
	[Column(Storage="_costCenter", Name="CostCenter", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> CostCenter
	{
		get
		{
			return this._costCenter;
		}
		set
		{
			if ((_costCenter != value))
			{
				this.OnCostCenterChanging(value);
				this.SendPropertyChanging();
				this._costCenter = value;
				this.SendPropertyChanged("CostCenter");
				this.OnCostCenterChanged();
			}
		}
	}
	
	[Column(Storage="_departmentID", Name="DepartmentID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int DepartmentID
	{
		get
		{
			return this._departmentID;
		}
		set
		{
			if ((_departmentID != value))
			{
				this.OnDepartmentIDChanging(value);
				this.SendPropertyChanging();
				this._departmentID = value;
				this.SendPropertyChanged("DepartmentID");
				this.OnDepartmentIDChanged();
			}
		}
	}
	
	[Column(Storage="_description", Name="Description", DbType="varchar", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Description
	{
		get
		{
			return this._description;
		}
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
	
	#region Children
	[Association(Storage="_holyDay", OtherKey="Department", ThisKey="DepartmentID", Name="HOLYDAY_DEPARTMENTHOLYDAY")]
	[DebuggerNonUserCode()]
	internal EntitySet<Holyday> HolyDay
	{
		get
		{
			return this._holyDay;
		}
		set
		{
			this._holyDay = value;
		}
	}
	
	[Association(Storage="_staff", OtherKey="Department", ThisKey="DepartmentID", Name="STAFF_DEPARTMENTSTAFF")]
	[DebuggerNonUserCode()]
	internal EntitySet<Staff> Staff
	{
		get
		{
			return this._staff;
		}
		set
		{
			this._staff = value;
		}
	}
	
	[Association(Storage="_processElement", OtherKey="Department", ThisKey="DepartmentID", Name="PROCESSELEMENT_DEPARTMENTPROCESSELEMENT")]
	[DebuggerNonUserCode()]
	internal EntitySet<ProcessElement> ProcessElement
	{
		get
		{
			return this._processElement;
		}
		set
		{
			this._processElement = value;
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
	private void HolyDay_Attach(Holyday entity)
	{
		this.SendPropertyChanging();
		entity.DepartmentDepartment = this;
	}
	
	private void HolyDay_Detach(Holyday entity)
	{
		this.SendPropertyChanging();
		entity.DepartmentDepartment = null;
	}
	
	private void Staff_Attach(Staff entity)
	{
		this.SendPropertyChanging();
		entity.DepartmentDepartment = this;
	}
	
	private void Staff_Detach(Staff entity)
	{
		this.SendPropertyChanging();
		entity.DepartmentDepartment = null;
	}
	
	private void ProcessElement_Attach(ProcessElement entity)
	{
		this.SendPropertyChanging();
		entity.DepartmentDepartment = this;
	}
	
	private void ProcessElement_Detach(ProcessElement entity)
	{
		this.SendPropertyChanging();
		entity.DepartmentDepartment = null;
	}
	#endregion
}

}