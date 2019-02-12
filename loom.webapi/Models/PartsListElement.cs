using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{

[Table(Name="LOOM.PartsListElement")]
public partial class PartsListElement : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<int> _activity;
	
	private System.Nullable<int> _artikelID;
	
	private string _historicalPpl;
	
	private System.Nullable<decimal> _historicalPrice;
	
	private int _partsListElementID;
	
	private System.Nullable<int> _quantity;
	
	private EntityRef<Activity> _activityActivity = new EntityRef<Activity>();
	
	private EntityRef<PPL> _ppL = new EntityRef<PPL>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActivityChanged();
		
		partial void OnActivityChanging(System.Nullable<int> value);
		
		partial void OnArtikelIDChanged();
		
		partial void OnArtikelIDChanging(System.Nullable<int> value);
		
		partial void OnHistoricalPplChanged();
		
		partial void OnHistoricalPplChanging(string value);
		
		partial void OnHistoricalPriceChanged();
		
		partial void OnHistoricalPriceChanging(System.Nullable<decimal> value);
		
		partial void OnPartsListElementIDChanged();
		
		partial void OnPartsListElementIDChanging(int value);
		
		partial void OnQuantityChanged();
		
		partial void OnQuantityChanging(System.Nullable<int> value);
		#endregion
	
	
	public PartsListElement()
	{
		this.OnCreated();
	}
	
	[Column(Storage="_activity", Name="Activity", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Activity
	{
		get
		{
			return this._activity;
		}
		set
		{
			if ((_activity != value))
			{
				if (_activityActivity.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnActivityChanging(value);
				this.SendPropertyChanging();
				this._activity = value;
				this.SendPropertyChanged("Activity");
				this.OnActivityChanged();
			}
		}
	}
	
	[Column(Storage="_artikelID", Name="ArtikelID", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> ArtikelID
	{
		get
		{
			return this._artikelID;
		}
		set
		{
			if ((_artikelID != value))
			{
				if (_ppL.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnArtikelIDChanging(value);
				this.SendPropertyChanging();
				this._artikelID = value;
				this.SendPropertyChanged("ArtikelID");
				this.OnArtikelIDChanged();
			}
		}
	}
	
	[Column(Storage="_historicalPpl", Name="HistoricalPPL", DbType="varchar", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string HistoricalPpl
	{
		get
		{
			return this._historicalPpl;
		}
		set
		{
			if (((_historicalPpl == value) 
						== false))
			{
				this.OnHistoricalPplChanging(value);
				this.SendPropertyChanging();
				this._historicalPpl = value;
				this.SendPropertyChanged("HistoricalPpl");
				this.OnHistoricalPplChanged();
			}
		}
	}
	
	[Column(Storage="_historicalPrice", Name="HistoricalPrice", DbType="decimal", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<decimal> HistoricalPrice
	{
		get
		{
			return this._historicalPrice;
		}
		set
		{
			if ((_historicalPrice != value))
			{
				this.OnHistoricalPriceChanging(value);
				this.SendPropertyChanging();
				this._historicalPrice = value;
				this.SendPropertyChanged("HistoricalPrice");
				this.OnHistoricalPriceChanged();
			}
		}
	}
	
	[Column(Storage="_partsListElementID", Name="PartsListElementID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int PartsListElementID
	{
		get
		{
			return this._partsListElementID;
		}
		set
		{
			if ((_partsListElementID != value))
			{
				this.OnPartsListElementIDChanging(value);
				this.SendPropertyChanging();
				this._partsListElementID = value;
				this.SendPropertyChanged("PartsListElementID");
				this.OnPartsListElementIDChanged();
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
	
	#region Parents
	[Association(Storage="_activityActivity", OtherKey="ActivityID", ThisKey="Activity", Name="PARTSLISTELEMENT_ACTIVITYPARTSLISTELEMENT", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	internal Activity ActivityActivity
	{
		get
		{
			return this._activityActivity.Entity;
		}
		set
		{
			if (((this._activityActivity.Entity == value) 
						== false))
			{
				if ((this._activityActivity.Entity != null))
				{
					Activity previousActivity = this._activityActivity.Entity;
					this._activityActivity.Entity = null;
					previousActivity.PartsListElement.Remove(this);
				}
				this._activityActivity.Entity = value;
				if ((value != null))
				{
					value.PartsListElement.Add(this);
					_activity = value.ActivityID;
				}
				else
				{
					_activity = null;
				}
			}
		}
	}
	
	[Association(Storage="_ppL", OtherKey="ArticleID", ThisKey="ArtikelID", Name="PARTSLISTELEMENT_PPLPARTSLISTELEMENT", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	internal PPL PPL
	{
		get
		{
			return this._ppL.Entity;
		}
		set
		{
			if (((this._ppL.Entity == value) 
						== false))
			{
				if ((this._ppL.Entity != null))
				{
					PPL previousPPL = this._ppL.Entity;
					this._ppL.Entity = null;
					previousPPL.PartsListElement.Remove(this);
				}
				this._ppL.Entity = value;
				if ((value != null))
				{
					value.PartsListElement.Add(this);
					_artikelID = value.ArticleID;
				}
				else
				{
					_artikelID = null;
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