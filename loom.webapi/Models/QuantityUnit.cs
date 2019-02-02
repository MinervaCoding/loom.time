using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{
    
[Table(Name="LOOM.QuantityUnit")]
public partial class QuantityUnit : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private string _description;
	
	private int _quantityUnitID;
	
	private string _text;
	
	private EntitySet<TargetTime> _targetTime;
	
	private EntitySet<QuantityUnitKey> _quantityUnitKey;
	
	private EntitySet<ReferenceQuantity> _referenceQuantity;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnQuantityUnitIDChanged();
		
		partial void OnQuantityUnitIDChanging(int value);
		
		partial void OnTextChanged();
		
		partial void OnTextChanging(string value);
		#endregion
	
	
	public QuantityUnit()
	{
		_targetTime = new EntitySet<TargetTime>(new Action<TargetTime>(this.TargetTime_Attach), new Action<TargetTime>(this.TargetTime_Detach));
		_quantityUnitKey = new EntitySet<QuantityUnitKey>(new Action<QuantityUnitKey>(this.QuantityUnitKey_Attach), new Action<QuantityUnitKey>(this.QuantityUnitKey_Detach));
		_referenceQuantity = new EntitySet<ReferenceQuantity>(new Action<ReferenceQuantity>(this.ReferenceQuantity_Attach), new Action<ReferenceQuantity>(this.ReferenceQuantity_Detach));
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
	
	[Column(Storage="_quantityUnitID", Name="QuantityUnitID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int QuantityUnitID
	{
		get
		{
			return this._quantityUnitID;
		}
		set
		{
			if ((_quantityUnitID != value))
			{
				this.OnQuantityUnitIDChanging(value);
				this.SendPropertyChanging();
				this._quantityUnitID = value;
				this.SendPropertyChanged("QuantityUnitID");
				this.OnQuantityUnitIDChanged();
			}
		}
	}
	
	[Column(Storage="_text", Name="Text", DbType="varchar", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Text
	{
		get
		{
			return this._text;
		}
		set
		{
			if (((_text == value) 
						== false))
			{
				this.OnTextChanging(value);
				this.SendPropertyChanging();
				this._text = value;
				this.SendPropertyChanged("Text");
				this.OnTextChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_targetTime", OtherKey="QuantityUnit", ThisKey="QuantityUnitID", Name="TARGETTIME_QUANTITYUNITTARGETTIME")]
	[DebuggerNonUserCode()]
	public EntitySet<TargetTime> TargetTime
	{
		get
		{
			return this._targetTime;
		}
		set
		{
			this._targetTime = value;
		}
	}
	
	[Association(Storage="_quantityUnitKey", OtherKey="QuantityUnit", ThisKey="QuantityUnitID", Name="QUANTITYUNITKEY_QUANTITYUNITQUANTITYUNITKEY")]
	[DebuggerNonUserCode()]
	public EntitySet<QuantityUnitKey> QuantityUnitKey
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
	
	[Association(Storage="_referenceQuantity", OtherKey="QuantityUnit", ThisKey="QuantityUnitID", Name="REFERENCEQUANTITY_QUANTITYUNITREFERENCEQUANTITY")]
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
	private void TargetTime_Attach(TargetTime entity)
	{
		this.SendPropertyChanging();
		entity.QuantityUnitQuantityUnit = this;
	}
	
	private void TargetTime_Detach(TargetTime entity)
	{
		this.SendPropertyChanging();
		entity.QuantityUnitQuantityUnit = null;
	}
	
	private void QuantityUnitKey_Attach(QuantityUnitKey entity)
	{
		this.SendPropertyChanging();
		entity.QuantityUnitQuantityUnit = this;
	}
	
	private void QuantityUnitKey_Detach(QuantityUnitKey entity)
	{
		this.SendPropertyChanging();
		entity.QuantityUnitQuantityUnit = null;
	}
	
	private void ReferenceQuantity_Attach(ReferenceQuantity entity)
	{
		this.SendPropertyChanging();
		entity.QuantityUnitQuantityUnit = this;
	}
	
	private void ReferenceQuantity_Detach(ReferenceQuantity entity)
	{
		this.SendPropertyChanging();
		entity.QuantityUnitQuantityUnit = null;
	}
	#endregion
}



}