using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{
[Table(Name="LOOM.PPL")]
public partial class PPL : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private int _articleID;
	
	private string _description;
	
	private System.Nullable<decimal> _price;
	
	private System.Nullable<decimal> _priceFactor;
	
	private System.Nullable<int> _productGroup;
	
	private System.Nullable<decimal> _weight;
	
	private EntitySet<PartsListElement> _partsListElement;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnArticleIDChanged();
		
		partial void OnArticleIDChanging(int value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnPriceChanged();
		
		partial void OnPriceChanging(System.Nullable<decimal> value);
		
		partial void OnPriceFactorChanged();
		
		partial void OnPriceFactorChanging(System.Nullable<decimal> value);
		
		partial void OnProductGroupChanged();
		
		partial void OnProductGroupChanging(System.Nullable<int> value);
		
		partial void OnWeightChanged();
		
		partial void OnWeightChanging(System.Nullable<decimal> value);
		#endregion
	
	
	public PPL()
	{
		_partsListElement = new EntitySet<PartsListElement>(new Action<PartsListElement>(this.PartsListElement_Attach), new Action<PartsListElement>(this.PartsListElement_Detach));
		this.OnCreated();
	}
	
	[Column(Storage="_articleID", Name="ArticleID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int ArticleID
	{
		get
		{
			return this._articleID;
		}
		set
		{
			if ((_articleID != value))
			{
				this.OnArticleIDChanging(value);
				this.SendPropertyChanging();
				this._articleID = value;
				this.SendPropertyChanged("ArticleID");
				this.OnArticleIDChanged();
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
	
	[Column(Storage="_price", Name="Price", DbType="decimal", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<decimal> Price
	{
		get
		{
			return this._price;
		}
		set
		{
			if ((_price != value))
			{
				this.OnPriceChanging(value);
				this.SendPropertyChanging();
				this._price = value;
				this.SendPropertyChanged("Price");
				this.OnPriceChanged();
			}
		}
	}
	
	[Column(Storage="_priceFactor", Name="PriceFactor", DbType="decimal", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<decimal> PriceFactor
	{
		get
		{
			return this._priceFactor;
		}
		set
		{
			if ((_priceFactor != value))
			{
				this.OnPriceFactorChanging(value);
				this.SendPropertyChanging();
				this._priceFactor = value;
				this.SendPropertyChanged("PriceFactor");
				this.OnPriceFactorChanged();
			}
		}
	}
	
	[Column(Storage="_productGroup", Name="ProductGroup", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> ProductGroup
	{
		get
		{
			return this._productGroup;
		}
		set
		{
			if ((_productGroup != value))
			{
				this.OnProductGroupChanging(value);
				this.SendPropertyChanging();
				this._productGroup = value;
				this.SendPropertyChanged("ProductGroup");
				this.OnProductGroupChanged();
			}
		}
	}
	
	[Column(Storage="_weight", Name="Weight", DbType="decimal", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<decimal> Weight
	{
		get
		{
			return this._weight;
		}
		set
		{
			if ((_weight != value))
			{
				this.OnWeightChanging(value);
				this.SendPropertyChanging();
				this._weight = value;
				this.SendPropertyChanged("Weight");
				this.OnWeightChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_partsListElement", OtherKey="ArtikelID", ThisKey="ArticleID", Name="PARTSLISTELEMENT_PPLPARTSLISTELEMENT")]
	[DebuggerNonUserCode()]
	public EntitySet<PartsListElement> PartsListElement
	{
		get
		{
			return this._partsListElement;
		}
		set
		{
			this._partsListElement = value;
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
	private void PartsListElement_Attach(PartsListElement entity)
	{
		this.SendPropertyChanging();
		entity.PPL = this;
	}
	
	private void PartsListElement_Detach(PartsListElement entity)
	{
		this.SendPropertyChanging();
		entity.PPL = null;
	}
	#endregion
}


}