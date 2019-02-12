using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{
[Table(Name="LOOM.Subsidiary")]
public partial class Subsidiary : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<int> _country;
	
	private string _description;
	
	private int _subsidiaryID;
	
	private EntitySet<ProjectElement> _projectElement;
	
	private EntityRef<Country> _countryCountry = new EntityRef<Country>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCountryChanged();
		
		partial void OnCountryChanging(System.Nullable<int> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnSubsidiaryIDChanged();
		
		partial void OnSubsidiaryIDChanging(int value);
		#endregion
	
	
	public Subsidiary()
	{
		_projectElement = new EntitySet<ProjectElement>(new Action<ProjectElement>(this.ProjectElement_Attach), new Action<ProjectElement>(this.ProjectElement_Detach));
		this.OnCreated();
	}
	
	[Column(Storage="_country", Name="Country", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Country
	{
		get
		{
			return this._country;
		}
		set
		{
			if ((_country != value))
			{
				if (_countryCountry.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCountryChanging(value);
				this.SendPropertyChanging();
				this._country = value;
				this.SendPropertyChanged("Country");
				this.OnCountryChanged();
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
	
	[Column(Storage="_subsidiaryID", Name="SubsidiaryID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int SubsidiaryID
	{
		get
		{
			return this._subsidiaryID;
		}
		set
		{
			if ((_subsidiaryID != value))
			{
				this.OnSubsidiaryIDChanging(value);
				this.SendPropertyChanging();
				this._subsidiaryID = value;
				this.SendPropertyChanged("SubsidiaryID");
				this.OnSubsidiaryIDChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_projectElement", OtherKey="Subsidiary", ThisKey="SubsidiaryID", Name="PROJECTELEMENT_SUBSIDIARYPROJECTELEMENT")]
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
	[Association(Storage="_countryCountry", OtherKey="CountryID", ThisKey="Country", Name="SUBSIDIARY_COUNTRYSUBSIDIARY", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	internal Country CountryCountry
	{
		get
		{
			return this._countryCountry.Entity;
		}
		set
		{
			if (((this._countryCountry.Entity == value) 
						== false))
			{
				if ((this._countryCountry.Entity != null))
				{
					Country previousCountry = this._countryCountry.Entity;
					this._countryCountry.Entity = null;
					previousCountry.Subsidiary.Remove(this);
				}
				this._countryCountry.Entity = value;
				if ((value != null))
				{
					value.Subsidiary.Add(this);
					_country = value.CountryID;
				}
				else
				{
					_country = null;
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
	private void ProjectElement_Attach(ProjectElement entity)
	{
		this.SendPropertyChanging();
		entity.SubsidiarySubsidiary = this;
	}
	
	private void ProjectElement_Detach(ProjectElement entity)
	{
		this.SendPropertyChanging();
		entity.SubsidiarySubsidiary = null;
	}
	#endregion
}

}