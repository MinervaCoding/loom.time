using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Web.ApplicationServices;
using System.Runtime.Serialization;

namespace loom.webapi.models
{
[Table(Name="LOOM.Staff")]
//[KnownTypeAttribute(typeof(Department))]
public partial class Staff : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<int> _department;
	
	private string _firstName;
	
	private System.Nullable<int> _hoursPerWeek;
	
	private string _lastName;
	
	private System.Nullable<int> _skill;
	
	private int _staffID;
	
	private string _windowsUser;
	
	private EntitySet<Performance> _performance;
	
	private EntitySet<ResourceAllocation> _resourceAllocation;
	
	private EntitySet<AbsenceDay> _absenceDay;
	
	private EntitySet<ProjectElement> _projectElement;
	
	private EntityRef<Department> _departmentDepartment = new EntityRef<Department>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDepartmentChanged();
		
		partial void OnDepartmentChanging(System.Nullable<int> value);
		
		partial void OnFirstNameChanged();
		
		partial void OnFirstNameChanging(string value);
		
		partial void OnHoursPerWeekChanged();
		
		partial void OnHoursPerWeekChanging(System.Nullable<int> value);
		
		partial void OnLastNameChanged();
		
		partial void OnLastNameChanging(string value);
		
		partial void OnSkillChanged();
		
		partial void OnSkillChanging(System.Nullable<int> value);
		
		partial void OnStaffIDChanged();
		
		partial void OnStaffIDChanging(int value);
		
		partial void OnWindowsUserChanged();
		
		partial void OnWindowsUserChanging(string value);
		#endregion
	
	
	public Staff()
	{
		_performance = new EntitySet<Performance>(new Action<Performance>(this.Performance_Attach), new Action<Performance>(this.Performance_Detach));
		_resourceAllocation = new EntitySet<ResourceAllocation>(new Action<ResourceAllocation>(this.ResourceAllocation_Attach), new Action<ResourceAllocation>(this.ResourceAllocation_Detach));
		_absenceDay = new EntitySet<AbsenceDay>(new Action<AbsenceDay>(this.AbsenceDay_Attach), new Action<AbsenceDay>(this.AbsenceDay_Detach));
		_projectElement = new EntitySet<ProjectElement>(new Action<ProjectElement>(this.ProjectElement_Attach), new Action<ProjectElement>(this.ProjectElement_Detach));
		this.OnCreated();
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
	
	[Column(Storage="_firstName", Name="FirstName", DbType="varchar", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string FirstName
	{
		get
		{
			return this._firstName;
		}
		set
		{
			if (((_firstName == value) 
						== false))
			{
				this.OnFirstNameChanging(value);
				this.SendPropertyChanging();
				this._firstName = value;
				this.SendPropertyChanged("FirstName");
				this.OnFirstNameChanged();
			}
		}
	}
	
	[Column(Storage="_hoursPerWeek", Name="HoursPerWeek", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> HoursPerWeek
	{
		get
		{
			return this._hoursPerWeek;
		}
		set
		{
			if ((_hoursPerWeek != value))
			{
				this.OnHoursPerWeekChanging(value);
				this.SendPropertyChanging();
				this._hoursPerWeek = value;
				this.SendPropertyChanged("HoursPerWeek");
				this.OnHoursPerWeekChanged();
			}
		}
	}
	
	[Column(Storage="_lastName", Name="LastName", DbType="varchar", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string LastName
	{
		get
		{
			return this._lastName;
		}
		set
		{
			if (((_lastName == value) 
						== false))
			{
				this.OnLastNameChanging(value);
				this.SendPropertyChanging();
				this._lastName = value;
				this.SendPropertyChanged("LastName");
				this.OnLastNameChanged();
			}
		}
	}
	
	[Column(Storage="_skill", Name="Skill", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Skill
	{
		get
		{
			return this._skill;
		}
		set
		{
			if ((_skill != value))
			{
				this.OnSkillChanging(value);
				this.SendPropertyChanging();
				this._skill = value;
				this.SendPropertyChanged("Skill");
				this.OnSkillChanged();
			}
		}
	}
	
	[Column(Storage="_staffID", Name="StaffID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int StaffID
	{
		get
		{
			return this._staffID;
		}
		set
		{
			if ((_staffID != value))
			{
				this.OnStaffIDChanging(value);
				this.SendPropertyChanging();
				this._staffID = value;
				this.SendPropertyChanged("StaffID");
				this.OnStaffIDChanged();
			}
		}
	}
	
	[Column(Storage="_windowsUser", Name="WindowsUser", DbType="varchar", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string WindowsUser
	{
		get
		{
			return this._windowsUser;
		}
		set
		{
			if (((_windowsUser == value) 
						== false))
			{
				this.OnWindowsUserChanging(value);
				this.SendPropertyChanging();
				this._windowsUser = value;
				this.SendPropertyChanged("WindowsUser");
				this.OnWindowsUserChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_performance", OtherKey="Staff", ThisKey="StaffID", Name="PERFORMANCE_STAFFPERFORMANCE")]
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
	
	[Association(Storage="_resourceAllocation", OtherKey="Staff", ThisKey="StaffID", Name="RESOURCEALLOCATION_STAFFRESOURCEALLOCATION")]
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
	
	[Association(Storage="_absenceDay", OtherKey="Staff", ThisKey="StaffID", Name="ABSENCEDAY_STAFFABSENCEDAY")]
	[DebuggerNonUserCode()]
	internal EntitySet<AbsenceDay> AbsenceDay
	{
		get
		{
			return this._absenceDay;
		}
		set
		{
			this._absenceDay = value;
		}
	}
	
	[Association(Storage="_projectElement", OtherKey="PerEsponsible", ThisKey="StaffID", Name="PROJECTELEMENT_STAFFPROJECTELEMENT")]
	[DebuggerNonUserCode()]
	internal EntitySet<ProjectElement> ProjectElement
	{
		get
		{
			return this._projectElement;
		}
		set
		{
			this._projectElement = value;
		}
	}
	#endregion
	
	#region Parents
	[Association(Storage="_departmentDepartment", OtherKey="DepartmentID", ThisKey="Department", Name="STAFF_DEPARTMENTSTAFF", IsForeignKey=true)]
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
					previousDepartment.Staff.Remove(this);
				}
				this._departmentDepartment.Entity = value;
				if ((value != null))
				{
					value.Staff.Add(this);
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
	
	#region Attachment handlers
	private void Performance_Attach(Performance entity)
	{
		this.SendPropertyChanging();
		entity.StaffStaff = this;
	}
	
	private void Performance_Detach(Performance entity)
	{
		this.SendPropertyChanging();
		entity.StaffStaff = null;
	}
	
	private void ResourceAllocation_Attach(ResourceAllocation entity)
	{
		this.SendPropertyChanging();
		entity.StaffStaff = this;
	}
	
	private void ResourceAllocation_Detach(ResourceAllocation entity)
	{
		this.SendPropertyChanging();
		entity.StaffStaff = null;
	}
	
	private void AbsenceDay_Attach(AbsenceDay entity)
	{
		this.SendPropertyChanging();
		entity.StaffStaff = this;
	}
	
	private void AbsenceDay_Detach(AbsenceDay entity)
	{
		this.SendPropertyChanging();
		entity.StaffStaff = null;
	}
	
	private void ProjectElement_Attach(ProjectElement entity)
	{
		this.SendPropertyChanging();
		entity.Staff = this;
	}
	
	private void ProjectElement_Detach(ProjectElement entity)
	{
		this.SendPropertyChanging();
		entity.Staff = null;
	}
	#endregion
}

}