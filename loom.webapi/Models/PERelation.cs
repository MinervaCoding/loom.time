using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{
[Table(Name="LOOM.PERelation")]
public partial class PERelation : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<int> _PEPredecessor;
	
	private int _PERelationID;
	
	private System.Nullable<int> _PESuccessor;
	
	private EntityRef<ProcessElement> _processElement = new EntityRef<ProcessElement>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnPepRedecessorChanged();
		
		partial void OnPepRedecessorChanging(System.Nullable<int> value);
		
		partial void OnPerElationIDChanged();
		
		partial void OnPerElationIDChanging(int value);
		
		partial void OnPesUccessorChanged();
		
		partial void OnPesUccessorChanging(System.Nullable<int> value);
		#endregion
	
	
	public PERelation()
	{
		this.OnCreated();
	}
	
	[Column(Storage="_PEPredecessor", Name="PEPredecessor", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> PEPredecessor
	{
		get
		{
			return this._PEPredecessor;
		}
		set
		{
			if ((_PEPredecessor != value))
			{
				this.OnPepRedecessorChanging(value);
				this.SendPropertyChanging();
				this._PEPredecessor = value;
				this.SendPropertyChanged("PEPredecessor");
				this.OnPepRedecessorChanged();
			}
		}
	}
	
	[Column(Storage="_PERelationID", Name="PERelationID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int PERelationId
	{
		get
		{
			return this._PERelationID;
		}
		set
		{
			if ((_PERelationID != value))
			{
				this.OnPerElationIDChanging(value);
				this.SendPropertyChanging();
				this._PERelationID = value;
				this.SendPropertyChanged("PERelationId");
				this.OnPerElationIDChanged();
			}
		}
	}
	
	[Column(Storage="_PESuccessor", Name="PESuccessor", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> PESuccessor
	{
		get
		{
			return this._PESuccessor;
		}
		set
		{
			if ((_PESuccessor != value))
			{
				this.OnPesUccessorChanging(value);
				this.SendPropertyChanging();
				this._PESuccessor = value;
				this.SendPropertyChanged("PESuccessor");
				this.OnPesUccessorChanged();
			}
		}
	}
	
	#region Parents
	[Association(Storage="_processElement", OtherKey="ProcessElementID", ThisKey="PESuccessor", Name="PROCESSELEMENT_PERELATION_SUCCESSOR", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public ProcessElement ProcessElementSuccessor
	{
		get
		{
			return this._processElement.Entity;
		}
		set
		{
			if (((this._processElement.Entity == value) 
						== false))
			{
				if ((this._processElement.Entity != null))
				{
					ProcessElement previousProcessElement = this._processElement.Entity;
					this._processElement.Entity = null;
					previousProcessElement.PERelationSuccessor.Remove(this);
				}
				this._processElement.Entity = value;
				if ((value != null))
				{
					value.PERelationSuccessor.Add(this);
					_PESuccessor = value.ProcessElementID;
				}
				else
				{
					_PESuccessor = null;
				}
			}
		}
	}
	
	[Association(Storage="_processElement", OtherKey="ProcessElementID", ThisKey="PEPredecessor", Name="PROCESSELEMENT_PERELATION_PREDECESSOR", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public ProcessElement ProcessElementPredecessor
	{
		get
		{
			return this._processElement.Entity;
		}
		set
		{
			if (((this._processElement.Entity == value) 
			     == false))
			{
				if ((this._processElement.Entity != null))
				{
					ProcessElement previousProcessElement = this._processElement.Entity;
					this._processElement.Entity = null;
					previousProcessElement.PERelationPredecessor.Remove(this);
				}
				this._processElement.Entity = value;
				if ((value != null))
				{
					value.PERelationPredecessor.Add(this);
					_PEPredecessor = value.ProcessElementID;
				}
				else
				{
					_PEPredecessor = null;
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