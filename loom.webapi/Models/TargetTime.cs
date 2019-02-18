using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;


namespace loom.webapi.models
{
[Table(Name="LOOM.TargetTime")]
public partial class TargetTime : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<int> _processElement;
	
	private System.Nullable<int> _quantityUnit;
	
	private int _targetTimeID;
	
	private System.Nullable<int> _underlyingNumber;
	
	private System.Nullable<int> _value;
	
	private string _variance;
	
	private EntityRef<QuantityUnit> _quantityUnitQuantityUnit = new EntityRef<QuantityUnit>();
	
	private EntityRef<ProcessElement> _processElementProcessElement = new EntityRef<ProcessElement>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnProcessElementChanged();
		
		partial void OnProcessElementChanging(System.Nullable<int> value);
		
		partial void OnQuantityUnitChanged();
		
		partial void OnQuantityUnitChanging(System.Nullable<int> value);
		
		partial void OnTargetTimeIDChanged();
		
		partial void OnTargetTimeIDChanging(int value);
		
		partial void OnUnderlyingNumberChanged();
		
		partial void OnUnderlyingNumberChanging(System.Nullable<int> value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		
		partial void OnVarianceChanged();
		
		partial void OnVarianceChanging(string value);
		#endregion
	
	
	public TargetTime()
	{
		this.OnCreated();
	}
	
	[Column(Storage="_processElement", Name="ProcessElement", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> ProcessElement
	{
		get
		{
			return this._processElement;
		}
		set
		{
			if ((_processElement != value))
			{
				if (_processElementProcessElement.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnProcessElementChanging(value);
				this.SendPropertyChanging();
				this._processElement = value;
				this.SendPropertyChanged("ProcessElement");
				this.OnProcessElementChanged();
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
	
	[Column(Storage="_targetTimeID", Name="TargetTimeID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.OnInsert, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int TargetTimeID
	{
		get
		{
			return this._targetTimeID;
		}
		set
		{
			if ((_targetTimeID != value))
			{
				this.OnTargetTimeIDChanging(value);
				this.SendPropertyChanging();
				this._targetTimeID = value;
				this.SendPropertyChanged("TargetTimeID");
				this.OnTargetTimeIDChanged();
			}
		}
	}
	
	[Column(Storage="_underlyingNumber", Name="UnderlyingNumber", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> UnderlyingNumber
	{
		get
		{
			return this._underlyingNumber;
		}
		set
		{
			if ((_underlyingNumber != value))
			{
				this.OnUnderlyingNumberChanging(value);
				this.SendPropertyChanging();
				this._underlyingNumber = value;
				this.SendPropertyChanged("UnderlyingNumber");
				this.OnUnderlyingNumberChanged();
			}
		}
	}
	
	[Column(Storage="_value", Name="Value", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Value
	{
		get
		{
			return this._value;
		}
		set
		{
			if ((_value != value))
			{
				this.OnValueChanging(value);
				this.SendPropertyChanging();
				this._value = value;
				this.SendPropertyChanged("Value");
				this.OnValueChanged();
			}
		}
	}
	
	[Column(Storage="_variance", Name="Variance", DbType="varchar", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Variance
	{
		get
		{
			return this._variance;
		}
		set
		{
			if (((_variance == value) 
						== false))
			{
				this.OnVarianceChanging(value);
				this.SendPropertyChanging();
				this._variance = value;
				this.SendPropertyChanged("Variance");
				this.OnVarianceChanged();
			}
		}
	}
	
	#region Parents
	[Association(Storage="_quantityUnitQuantityUnit", OtherKey="QuantityUnitID", ThisKey="QuantityUnit", Name="TARGETTIME_QUANTITYUNITTARGETTIME", IsForeignKey=true)]
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
					previousQuantityUnit.TargetTime.Remove(this);
				}
				this._quantityUnitQuantityUnit.Entity = value;
				if ((value != null))
				{
					value.TargetTime.Add(this);
					_quantityUnit = value.QuantityUnitID;
				}
				else
				{
					_quantityUnit = null;
				}
			}
		}
	}
	
	[Association(Storage="_processElementProcessElement", OtherKey="ProcessElementID", ThisKey="ProcessElement", Name="TARGETTIME_PROCESSELEMENTTARGETTIME", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	internal ProcessElement ProcessElementProcessElement
	{
		get
		{
			return this._processElementProcessElement.Entity;
		}
		set
		{
			if (((this._processElementProcessElement.Entity == value) 
						== false))
			{
				if ((this._processElementProcessElement.Entity != null))
				{
					ProcessElement previousProcessElement = this._processElementProcessElement.Entity;
					this._processElementProcessElement.Entity = null;
					previousProcessElement.TargetTime.Remove(this);
				}
				this._processElementProcessElement.Entity = value;
				if ((value != null))
				{
					value.TargetTime.Add(this);
					_processElement = value.ProcessElementID;
				}
				else
				{
					_processElement = null;
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