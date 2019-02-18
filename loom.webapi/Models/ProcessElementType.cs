using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{
[Table(Name="LOOM.ProcessElementType")]
public partial class ProcessElementType : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private string _description;
	
	private System.Nullable<int> _level;
	
	private int _processElementTypeID;
	
	private EntitySet<ProcessElement> _processElement;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnLevelChanged();
		
		partial void OnLevelChanging(System.Nullable<int> value);
		
		partial void OnProcessElementTypeIDChanged();
		
		partial void OnProcessElementTypeIDChanging(int value);
		#endregion
	
	
	public ProcessElementType()
	{
		_processElement = new EntitySet<ProcessElement>(new Action<ProcessElement>(this.ProcessElement_Attach), new Action<ProcessElement>(this.ProcessElement_Detach));
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
	
	[Column(Storage="_level", Name="Level", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Level
	{
		get
		{
			return this._level;
		}
		set
		{
			if ((_level != value))
			{
				this.OnLevelChanging(value);
				this.SendPropertyChanging();
				this._level = value;
				this.SendPropertyChanged("Level");
				this.OnLevelChanged();
			}
		}
	}
	
	[Column(Storage="_processElementTypeID", Name="ProcessElementTypeID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.OnInsert, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int ProcessElementTypeID
	{
		get
		{
			return this._processElementTypeID;
		}
		set
		{
			if ((_processElementTypeID != value))
			{
				this.OnProcessElementTypeIDChanging(value);
				this.SendPropertyChanging();
				this._processElementTypeID = value;
				this.SendPropertyChanged("ProcessElementTypeID");
				this.OnProcessElementTypeIDChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_processElement", OtherKey="ProcessElementType", ThisKey="ProcessElementTypeID", Name="PROCESSELEMENT_PROCESSELEMENTTYPEPROCESSELEMENT")]
	[DebuggerNonUserCode()]
	internal EntitySet<ProcessElement> ProcessElement
	{
		get
		{
			return this._processElement;
		}
		set
		{
			this._processElement = value;
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
	private void ProcessElement_Attach(ProcessElement entity)
	{
		this.SendPropertyChanging();
		entity.ProcessElementTypeProcessElementType = this;
	}
	
	private void ProcessElement_Detach(ProcessElement entity)
	{
		this.SendPropertyChanging();
		entity.ProcessElementTypeProcessElementType = null;
	}
	#endregion
}

}