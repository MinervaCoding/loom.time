using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{

[Table(Name="LOOM.Complexity")]
public partial class Complexity : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private string _complexityAbc;
	
	private System.Nullable<float> _factor;
	
	private EntitySet<Activity> _activity;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnComplexityAbcChanged();
		
		partial void OnComplexityAbcChanging(string value);
		
		partial void OnFactorChanged();
		
		partial void OnFactorChanging(System.Nullable<float> value);
		#endregion
	
	
	public Complexity()
	{
		_activity = new EntitySet<Activity>(new Action<Activity>(this.Activity_Attach), new Action<Activity>(this.Activity_Detach));
		this.OnCreated();
	}
	
	[Column(Storage="_complexityAbc", Name="ComplexityABC", DbType="varchar", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public string ComplexityAbc
	{
		get
		{
			return this._complexityAbc;
		}
		set
		{
			if (((_complexityAbc == value) 
						== false))
			{
				this.OnComplexityAbcChanging(value);
				this.SendPropertyChanging();
				this._complexityAbc = value;
				this.SendPropertyChanged("ComplexityAbc");
				this.OnComplexityAbcChanged();
			}
		}
	}
	
	[Column(Storage="_factor", Name="Factor", DbType="real", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<float> Factor
	{
		get
		{
			return this._factor;
		}
		set
		{
			if ((_factor != value))
			{
				this.OnFactorChanging(value);
				this.SendPropertyChanging();
				this._factor = value;
				this.SendPropertyChanged("Factor");
				this.OnFactorChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_activity", OtherKey="Complexity", ThisKey="ComplexityAbc", Name="ACTIVITY_COMPLEXITYACTIVITY")]
	[DebuggerNonUserCode()]
	internal EntitySet<Activity> Activity
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
		entity.ComplexityComplexity = this;
	}
	
	private void Activity_Detach(Activity entity)
	{
		this.SendPropertyChanging();
		entity.ComplexityComplexity = null;
	}
	#endregion
}

}