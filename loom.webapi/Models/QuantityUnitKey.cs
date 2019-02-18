using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{
    
[Table(Name="LOOM.QuantityUnitKey")]
public partial class QuantityUnitKey : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<int> _projectElementType;
	
	private System.Nullable<int> _quantityUnit;
	
	private int _quantityUnitKeyID;
	
	private EntityRef<QuantityUnit> _quantityUnitQuantityUnit = new EntityRef<QuantityUnit>();
	
	private EntityRef<ProjectElementType> _projectElementTypeProjectElementType = new EntityRef<ProjectElementType>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnProjectElementTypeChanged();
		
		partial void OnProjectElementTypeChanging(System.Nullable<int> value);
		
		partial void OnQuantityUnitChanged();
		
		partial void OnQuantityUnitChanging(System.Nullable<int> value);
		
		partial void OnQuantityUnitKeyIDChanged();
		
		partial void OnQuantityUnitKeyIDChanging(int value);
		#endregion
	
	
	public QuantityUnitKey()
	{
		this.OnCreated();
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
	
	[Column(Storage="_quantityUnit", Name="QuantityUnit", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> QuantityUnit
	{
		get
		{
			return this._quantityUnit;
		}
		set
		{
			if ((_quantityUnit != value))
			{
				if (_quantityUnitQuantityUnit.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnQuantityUnitChanging(value);
				this.SendPropertyChanging();
				this._quantityUnit = value;
				this.SendPropertyChanged("QuantityUnit");
				this.OnQuantityUnitChanged();
			}
		}
	}
	
	[Column(Storage="_quantityUnitKeyID", Name="QuantityUnitKeyID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.OnInsert, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int QuantityUnitKeyID
	{
		get
		{
			return this._quantityUnitKeyID;
		}
		set
		{
			if ((_quantityUnitKeyID != value))
			{
				this.OnQuantityUnitKeyIDChanging(value);
				this.SendPropertyChanging();
				this._quantityUnitKeyID = value;
				this.SendPropertyChanged("QuantityUnitKeyID");
				this.OnQuantityUnitKeyIDChanged();
			}
		}
	}
	
	#region Parents
	[Association(Storage="_quantityUnitQuantityUnit", OtherKey="QuantityUnitID", ThisKey="QuantityUnit", Name="QUANTITYUNITKEY_QUANTITYUNITQUANTITYUNITKEY", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	internal QuantityUnit QuantityUnitQuantityUnit
	{
		get
		{
			return this._quantityUnitQuantityUnit.Entity;
		}
		set
		{
			if (((this._quantityUnitQuantityUnit.Entity == value) 
						== false))
			{
				if ((this._quantityUnitQuantityUnit.Entity != null))
				{
					QuantityUnit previousQuantityUnit = this._quantityUnitQuantityUnit.Entity;
					this._quantityUnitQuantityUnit.Entity = null;
					previousQuantityUnit.QuantityUnitKey.Remove(this);
				}
				this._quantityUnitQuantityUnit.Entity = value;
				if ((value != null))
				{
					value.QuantityUnitKey.Add(this);
					_quantityUnit = value.QuantityUnitID;
				}
				else
				{
					_quantityUnit = null;
				}
			}
		}
	}
	
	[Association(Storage="_projectElementTypeProjectElementType", OtherKey="ProjectElementTypeID", ThisKey="ProjectElementType", Name="QUANTITYUNITKEY_PROJECTELEMENTTYPEQUANTITYUNITKEY", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	internal ProjectElementType ProjectElementTypeProjectElementType
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
					previousProjectElementType.QuantityUnitKey.Remove(this);
				}
				this._projectElementTypeProjectElementType.Entity = value;
				if ((value != null))
				{
					value.QuantityUnitKey.Add(this);
					_projectElementType = value.ProjectElementTypeID;
				}
				else
				{
					_projectElementType = null;
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