using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{
[Table(Name="LOOM.ProjectElement")]
public partial class ProjectElement : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private string _accountingType;
	
	private string _comment;
	
	private System.Nullable<int> _countryOfExecution;
	
	private System.Nullable<System.DateTime> _creationDate;
	
	private string _description;
	
	private System.Nullable<int> _perEsponsible;
	
	private System.Nullable<int> _predecessor;
	
	private int _projectElementID;
	
	private System.Nullable<int> _projectElementType;
	
	private System.Nullable<decimal> _projectNumber;
	
	private System.Nullable<int> _subsidiary;
	
	private EntitySet<Activity> _activity;
	
	private EntitySet<ReferenceQuantity> _referenceQuantity;
	
	private EntityRef<Country> _country = new EntityRef<Country>();
	
	private EntityRef<ProjectElementType> _projectElementTypeProjectElementType = new EntityRef<ProjectElementType>();
	
	private EntityRef<Staff> _staff = new EntityRef<Staff>();
	
	private EntityRef<Subsidiary> _subsidiarySubsidiary = new EntityRef<Subsidiary>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccountingTypeChanged();
		
		partial void OnAccountingTypeChanging(string value);
		
		partial void OnCommentChanged();
		
		partial void OnCommentChanging(string value);
		
		partial void OnCountryOfExecutionChanged();
		
		partial void OnCountryOfExecutionChanging(System.Nullable<int> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnPerEsponsibleChanged();
		
		partial void OnPerEsponsibleChanging(System.Nullable<int> value);
		
		partial void OnPredecessorChanged();
		
		partial void OnPredecessorChanging(System.Nullable<int> value);
		
		partial void OnProjectElementIDChanged();
		
		partial void OnProjectElementIDChanging(int value);
		
		partial void OnProjectElementTypeChanged();
		
		partial void OnProjectElementTypeChanging(System.Nullable<int> value);
		
		partial void OnProjectNumberChanged();
		
		partial void OnProjectNumberChanging(System.Nullable<decimal> value);
		
		partial void OnSubsidiaryChanged();
		
		partial void OnSubsidiaryChanging(System.Nullable<int> value);
		#endregion
	
	
	public ProjectElement()
	{
		_activity = new EntitySet<Activity>(new Action<Activity>(this.Activity_Attach), new Action<Activity>(this.Activity_Detach));
		_referenceQuantity = new EntitySet<ReferenceQuantity>(new Action<ReferenceQuantity>(this.ReferenceQuantity_Attach), new Action<ReferenceQuantity>(this.ReferenceQuantity_Detach));
		this.OnCreated();
	}
	
	[Column(Storage="_accountingType", Name="AccountingType", DbType="varchar", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string AccountingType
	{
		get
		{
			return this._accountingType;
		}
		set
		{
			if (((_accountingType == value) 
						== false))
			{
				this.OnAccountingTypeChanging(value);
				this.SendPropertyChanging();
				this._accountingType = value;
				this.SendPropertyChanged("AccountingType");
				this.OnAccountingTypeChanged();
			}
		}
	}
	
	[Column(Storage="_comment", Name="Comment", DbType="varchar", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Comment
	{
		get
		{
			return this._comment;
		}
		set
		{
			if (((_comment == value) 
						== false))
			{
				this.OnCommentChanging(value);
				this.SendPropertyChanging();
				this._comment = value;
				this.SendPropertyChanged("Comment");
				this.OnCommentChanged();
			}
		}
	}
	
	[Column(Storage="_countryOfExecution", Name="CountryOfExecution", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> CountryOfExecution
	{
		get
		{
			return this._countryOfExecution;
		}
		set
		{
			if ((_countryOfExecution != value))
			{
				if (_country.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCountryOfExecutionChanging(value);
				this.SendPropertyChanging();
				this._countryOfExecution = value;
				this.SendPropertyChanged("CountryOfExecution");
				this.OnCountryOfExecutionChanged();
			}
		}
	}
	
	[Column(Storage="_creationDate", Name="CreationDate", DbType="datetime", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<System.DateTime> CreationDate
	{
		get
		{
			return this._creationDate;
		}
		set
		{
			if ((_creationDate != value))
			{
				this.OnCreationDateChanging(value);
				this.SendPropertyChanging();
				this._creationDate = value;
				this.SendPropertyChanged("CreationDate");
				this.OnCreationDateChanged();
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
	
	[Column(Storage="_perEsponsible", Name="PEResponsible", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> PerEsponsible
	{
		get
		{
			return this._perEsponsible;
		}
		set
		{
			if ((_perEsponsible != value))
			{
				this.OnPerEsponsibleChanging(value);
				this.SendPropertyChanging();
				this._perEsponsible = value;
				this.SendPropertyChanged("PerEsponsible");
				this.OnPerEsponsibleChanged();
			}
		}
	}
	
	[Column(Storage="_predecessor", Name="Predecessor", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Predecessor
	{
		get
		{
			return this._predecessor;
		}
		set
		{
			if ((_predecessor != value))
			{
				this.OnPredecessorChanging(value);
				this.SendPropertyChanging();
				this._predecessor = value;
				this.SendPropertyChanged("Predecessor");
				this.OnPredecessorChanged();
			}
		}
	}
	
	[Column(Storage="_projectElementID", Name="ProjectElementID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int ProjectElementID
	{
		get
		{
			return this._projectElementID;
		}
		set
		{
			if ((_projectElementID != value))
			{
				this.OnProjectElementIDChanging(value);
				this.SendPropertyChanging();
				this._projectElementID = value;
				this.SendPropertyChanged("ProjectElementID");
				this.OnProjectElementIDChanged();
			}
		}
	}
	
	[Column(Storage="_projectElementType", Name="ProjectElementType", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> ProjectElementType
	{
		get
		{
			return this._projectElementType;
		}
		set
		{
			if ((_projectElementType != value))
			{
				if (_projectElementTypeProjectElementType.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnProjectElementTypeChanging(value);
				this.SendPropertyChanging();
				this._projectElementType = value;
				this.SendPropertyChanged("ProjectElementType");
				this.OnProjectElementTypeChanged();
			}
		}
	}
	
	[Column(Storage="_projectNumber", Name="ProjectNumber", DbType="numeric", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<decimal> ProjectNumber
	{
		get
		{
			return this._projectNumber;
		}
		set
		{
			if ((_projectNumber != value))
			{
				this.OnProjectNumberChanging(value);
				this.SendPropertyChanging();
				this._projectNumber = value;
				this.SendPropertyChanged("ProjectNumber");
				this.OnProjectNumberChanged();
			}
		}
	}
	
	[Column(Storage="_subsidiary", Name="Subsidiary", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Subsidiary
	{
		get
		{
			return this._subsidiary;
		}
		set
		{
			if ((_subsidiary != value))
			{
				if (_subsidiarySubsidiary.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnSubsidiaryChanging(value);
				this.SendPropertyChanging();
				this._subsidiary = value;
				this.SendPropertyChanged("Subsidiary");
				this.OnSubsidiaryChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_activity", OtherKey="ProjectElement", ThisKey="ProjectElementID", Name="ACTIVITY_PROJECTELEMENTACTIVITY")]
	[DebuggerNonUserCode()]
	public EntitySet<Activity> Activity
	{
		get
		{
			return this._activity;
		}
		set
		{
			this._activity = value;
		}
	}
	
	[Association(Storage="_referenceQuantity", OtherKey="ProjectElement", ThisKey="ProjectElementID", Name="REFERENCEQUANTITY_PROJECTELEMENTREFERENCEQUANTITY")]
	[DebuggerNonUserCode()]
	public EntitySet<ReferenceQuantity> ReferenceQuantity
	{
		get
		{
			return this._referenceQuantity;
		}
		set
		{
			this._referenceQuantity = value;
		}
	}
	#endregion
	
	#region Parents
	[Association(Storage="_country", OtherKey="CountryID", ThisKey="CountryOfExecution", Name="PROJECTELEMENT_COUNTRYPROJECTELEMENT", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public Country Country
	{
		get
		{
			return this._country.Entity;
		}
		set
		{
			if (((this._country.Entity == value) 
						== false))
			{
				if ((this._country.Entity != null))
				{
					Country previousCountry = this._country.Entity;
					this._country.Entity = null;
					previousCountry.ProjectElement.Remove(this);
				}
				this._country.Entity = value;
				if ((value != null))
				{
					value.ProjectElement.Add(this);
					_countryOfExecution = value.CountryID;
				}
				else
				{
					_countryOfExecution = null;
				}
			}
		}
	}
	
	[Association(Storage="_projectElementTypeProjectElementType", OtherKey="ProjectElementTypeID", ThisKey="ProjectElementType", Name="PROJECTELEMENT_PROJECTELEMENTTYPEPROJECTELEMENT", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public ProjectElementType ProjectElementTypeProjectElementType
	{
		get
		{
			return this._projectElementTypeProjectElementType.Entity;
		}
		set
		{
			if (((this._projectElementTypeProjectElementType.Entity == value) 
						== false))
			{
				if ((this._projectElementTypeProjectElementType.Entity != null))
				{
					ProjectElementType previousProjectElementType = this._projectElementTypeProjectElementType.Entity;
					this._projectElementTypeProjectElementType.Entity = null;
					previousProjectElementType.ProjectElement.Remove(this);
				}
				this._projectElementTypeProjectElementType.Entity = value;
				if ((value != null))
				{
					value.ProjectElement.Add(this);
					_projectElementType = value.ProjectElementTypeID;
				}
				else
				{
					_projectElementType = null;
				}
			}
		}
	}
	
	[Association(Storage="_staff", OtherKey="StaffID", ThisKey="PerEsponsible", Name="PROJECTELEMENT_STAFFPROJECTELEMENT", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public Staff Staff
	{
		get
		{
			return this._staff.Entity;
		}
		set
		{
			if (((this._staff.Entity == value) 
						== false))
			{
				if ((this._staff.Entity != null))
				{
					Staff previousStaff = this._staff.Entity;
					this._staff.Entity = null;
					previousStaff.ProjectElement.Remove(this);
				}
				this._staff.Entity = value;
				if ((value != null))
				{
					value.ProjectElement.Add(this);
					_perEsponsible = value.StaffID;
				}
				else
				{
					_perEsponsible = null;
				}
			}
		}
	}
	
	[Association(Storage="_subsidiarySubsidiary", OtherKey="SubsidiaryID", ThisKey="Subsidiary", Name="PROJECTELEMENT_SUBSIDIARYPROJECTELEMENT", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public Subsidiary SubsidiarySubsidiary
	{
		get
		{
			return this._subsidiarySubsidiary.Entity;
		}
		set
		{
			if (((this._subsidiarySubsidiary.Entity == value) 
						== false))
			{
				if ((this._subsidiarySubsidiary.Entity != null))
				{
					Subsidiary previousSubsidiary = this._subsidiarySubsidiary.Entity;
					this._subsidiarySubsidiary.Entity = null;
					previousSubsidiary.ProjectElement.Remove(this);
				}
				this._subsidiarySubsidiary.Entity = value;
				if ((value != null))
				{
					value.ProjectElement.Add(this);
					_subsidiary = value.SubsidiaryID;
				}
				else
				{
					_subsidiary = null;
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
	private void Activity_Attach(Activity entity)
	{
		this.SendPropertyChanging();
		entity.ProjectElementProjectElement = this;
	}
	
	private void Activity_Detach(Activity entity)
	{
		this.SendPropertyChanging();
		entity.ProjectElementProjectElement = null;
	}
	
	private void ReferenceQuantity_Attach(ReferenceQuantity entity)
	{
		this.SendPropertyChanging();
		entity.ProjectElementProjectElement = this;
	}
	
	private void ReferenceQuantity_Detach(ReferenceQuantity entity)
	{
		this.SendPropertyChanging();
		entity.ProjectElementProjectElement = null;
	}
	#endregion
}

}