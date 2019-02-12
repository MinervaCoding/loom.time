using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{
	
[Table(Name="LOOM.ProjectElementType")]
public partial class ProjectElementType : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private string _description;
	
	private int _projectElementTypeID;
	
	private EntitySet<ProjectElement> _projectElement;
	
	private EntitySet<QuantityUnitKey> _quantityUnitKey;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnProjectElementTypeIDChanged();
		
		partial void OnProjectElementTypeIDChanging(int value);
		#endregion
	
	
	public ProjectElementType()
	{
		_projectElement = new EntitySet<ProjectElement>(new Action<ProjectElement>(this.ProjectElement_Attach), new Action<ProjectElement>(this.ProjectElement_Detach));
		_quantityUnitKey = new EntitySet<QuantityUnitKey>(new Action<QuantityUnitKey>(this.QuantityUnitKey_Attach), new Action<QuantityUnitKey>(this.QuantityUnitKey_Detach));
		this.OnCreated();
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
	
	[Column(Storage="_projectElementTypeID", Name="ProjectElementTypeID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int ProjectElementTypeID
	{
		get
		{
			return this._projectElementTypeID;
		}
		set
		{
			if ((_projectElementTypeID != value))
			{
				this.OnProjectElementTypeIDChanging(value);
				this.SendPropertyChanging();
				this._projectElementTypeID = value;
				this.SendPropertyChanged("ProjectElementTypeID");
				this.OnProjectElementTypeIDChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_projectElement", OtherKey="ProjectElementType", ThisKey="ProjectElementTypeID", Name="PROJECTELEMENT_PROJECTELEMENTTYPEPROJECTELEMENT")]
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
	
	[Association(Storage="_quantityUnitKey", OtherKey="ProjectElementType", ThisKey="ProjectElementTypeID", Name="QUANTITYUNITKEY_PROJECTELEMENTTYPEQUANTITYUNITKEY")]
	[DebuggerNonUserCode()]
	internal EntitySet<QuantityUnitKey> QuantityUnitKey
	{
		get
		{
			return this._quantityUnitKey;
		}
		set
		{
			this._quantityUnitKey = value;
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
		entity.ProjectElementTypeProjectElementType = this;
	}
	
	private void ProjectElement_Detach(ProjectElement entity)
	{
		this.SendPropertyChanging();
		entity.ProjectElementTypeProjectElementType = null;
	}
	
	private void QuantityUnitKey_Attach(QuantityUnitKey entity)
	{
		this.SendPropertyChanging();
		entity.ProjectElementTypeProjectElementType = this;
	}
	
	private void QuantityUnitKey_Detach(QuantityUnitKey entity)
	{
		this.SendPropertyChanging();
		entity.ProjectElementTypeProjectElementType = null;
	}
	#endregion
}


}