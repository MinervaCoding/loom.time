using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{
[Table(Name="LOOM.ReferenceQuantity")]
public partial class ReferenceQuantity : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<int> _projectElement;
	
	private System.Nullable<int> _quantity;
	
	private System.Nullable<int> _quantityUnit;
	
	private int _referenceQuantityID;
	
	private EntityRef<QuantityUnit> _quantityUnitQuantityUnit = new EntityRef<QuantityUnit>();
	
	private EntityRef<ProjectElement> _projectElementProjectElement = new EntityRef<ProjectElement>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnProjectElementChanged();
		
		partial void OnProjectElementChanging(System.Nullable<int> value);
		
		partial void OnQuantityChanged();
		
		partial void OnQuantityChanging(System.Nullable<int> value);
		
		partial void OnQuantityUnitChanged();
		
		partial void OnQuantityUnitChanging(System.Nullable<int> value);
		
		partial void OnReferenceQuantityIDChanged();
		
		partial void OnReferenceQuantityIDChanging(int value);
		#endregion
	
	
	public ReferenceQuantity()
	{
		this.OnCreated();
	}
	
	[Column(Storage="_projectElement", Name="ProjectElement", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> ProjectElement
	{
		get
		{
			return this._projectElement;
		}
		set
		{
			if ((_projectElement != value))
			{
				if (_projectElementProjectElement.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnProjectElementChanging(value);
				this.SendPropertyChanging();
				this._projectElement = value;
				this.SendPropertyChanged("ProjectElement");
				this.OnProjectElementChanged();
			}
		}
	}
	
	[Column(Storage="_quantity", Name="Quantity", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Quantity
	{
		get
		{
			return this._quantity;
		}
		set
		{
			if ((_quantity != value))
			{
				this.OnQuantityChanging(value);
				this.SendPropertyChanging();
				this._quantity = value;
				this.SendPropertyChanged("Quantity");
				this.OnQuantityChanged();
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
	
	[Column(Storage="_referenceQuantityID", Name="ReferenceQuantityID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.OnInsert, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int ReferenceQuantityID
	{
		get
		{
			return this._referenceQuantityID;
		}
		set
		{
			if ((_referenceQuantityID != value))
			{
				this.OnReferenceQuantityIDChanging(value);
				this.SendPropertyChanging();
				this._referenceQuantityID = value;
				this.SendPropertyChanged("ReferenceQuantityID");
				this.OnReferenceQuantityIDChanged();
			}
		}
	}
	
	#region Parents
	[Association(Storage="_quantityUnitQuantityUnit", OtherKey="QuantityUnitID", ThisKey="QuantityUnit", Name="REFERENCEQUANTITY_QUANTITYUNITREFERENCEQUANTITY", IsForeignKey=true)]
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
					previousQuantityUnit.ReferenceQuantity.Remove(this);
				}
				this._quantityUnitQuantityUnit.Entity = value;
				if ((value != null))
				{
					value.ReferenceQuantity.Add(this);
					_quantityUnit = value.QuantityUnitID;
				}
				else
				{
					_quantityUnit = null;
				}
			}
		}
	}
	
	[Association(Storage="_projectElementProjectElement", OtherKey="ProjectElementID", ThisKey="ProjectElement", Name="REFERENCEQUANTITY_PROJECTELEMENTREFERENCEQUANTITY", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	internal ProjectElement ProjectElementProjectElement
	{
		get
		{
			return this._projectElementProjectElement.Entity;
		}
		set
		{
			if (((this._projectElementProjectElement.Entity == value) 
						== false))
			{
				if ((this._projectElementProjectElement.Entity != null))
				{
					ProjectElement previousProjectElement = this._projectElementProjectElement.Entity;
					this._projectElementProjectElement.Entity = null;
					previousProjectElement.ReferenceQuantity.Remove(this);
				}
				this._projectElementProjectElement.Entity = value;
				if ((value != null))
				{
					value.ReferenceQuantity.Add(this);
					_projectElement = value.ProjectElementID;
				}
				else
				{
					_projectElement = null;
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