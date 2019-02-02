using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{

[Table(Name="LOOM.Country")]
public partial class Country : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private int _countryID;
	
	private string _description;
	
	private EntitySet<Subsidiary> _subsidiary;
	
	private EntitySet<ProjectElement> _projectElement;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCountryIDChanged();
		
		partial void OnCountryIDChanging(int value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		#endregion
	
	
	public Country()
	{
		_subsidiary = new EntitySet<Subsidiary>(new Action<Subsidiary>(this.Subsidiary_Attach), new Action<Subsidiary>(this.Subsidiary_Detach));
		_projectElement = new EntitySet<ProjectElement>(new Action<ProjectElement>(this.ProjectElement_Attach), new Action<ProjectElement>(this.ProjectElement_Detach));
		this.OnCreated();
	}
	
	[Column(Storage="_countryID", Name="CountryID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int CountryID
	{
		get
		{
			return this._countryID;
		}
		set
		{
			if ((_countryID != value))
			{
				this.OnCountryIDChanging(value);
				this.SendPropertyChanging();
				this._countryID = value;
				this.SendPropertyChanged("CountryID");
				this.OnCountryIDChanged();
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
	[Association(Storage="_subsidiary", OtherKey="Country", ThisKey="CountryID", Name="SUBSIDIARY_COUNTRYSUBSIDIARY")]
	[DebuggerNonUserCode()]
	public EntitySet<Subsidiary> Subsidiary
	{
		get
		{
			return this._subsidiary;
		}
		set
		{
			this._subsidiary = value;
		}
	}
	
	[Association(Storage="_projectElement", OtherKey="CountryOfExecution", ThisKey="CountryID", Name="PROJECTELEMENT_COUNTRYPROJECTELEMENT")]
	[DebuggerNonUserCode()]
	public EntitySet<ProjectElement> ProjectElement
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
	private void Subsidiary_Attach(Subsidiary entity)
	{
		this.SendPropertyChanging();
		entity.CountryCountry = this;
	}
	
	private void Subsidiary_Detach(Subsidiary entity)
	{
		this.SendPropertyChanging();
		entity.CountryCountry = null;
	}
	
	private void ProjectElement_Attach(ProjectElement entity)
	{
		this.SendPropertyChanging();
		entity.Country = this;
	}
	
	private void ProjectElement_Detach(ProjectElement entity)
	{
		this.SendPropertyChanging();
		entity.Country = null;
	}
	#endregion
}

}