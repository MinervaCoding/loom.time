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
	
	private EntityRef<ProcessElement> _processelementPredecessor = new EntityRef<ProcessElement>();
    private EntityRef<ProcessElement> _processelementSuccessor = new EntityRef<ProcessElement>();

        #region Extensibility Method Declarations
        partial void OnCreated();
		
		partial void OnPEPredecessorChanged();
		
		partial void OnPEPredecessorChanging(System.Nullable<int> value);
		
		partial void OnPERelationIDChanged();
		
		partial void OnPERelationIDChanging(int value);
		
		partial void OnPESuccessorChanged();
		
		partial void OnPESuccessorChanging(System.Nullable<int> value);

        #endregion


        public PERelation()
	{
		this.OnCreated();
	}
	
	[Column(Storage= "_PEPredecessor", Name="PEPredecessor", DbType="int", AutoSync=AutoSync.Never)]
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
				this.OnPEPredecessorChanging(value);
				this.SendPropertyChanging();
				this._PEPredecessor = value;
				this.SendPropertyChanged("PEPredecessor");
				this.OnPEPredecessorChanged();
			}
		}
	}
	
	[Column(Storage="_PERelationID", Name="PERelationID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.OnInsert, CanBeNull=false)]
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
				this.OnPERelationIDChanging(value);
				this.SendPropertyChanging();
				this._PERelationID = value;
				this.SendPropertyChanged("PERelationId");
				this.OnPERelationIDChanged();
			}
		}
	}
	
	[Column(Storage= "_PESuccessor", Name="PESuccessor", DbType="int", AutoSync=AutoSync.Never)]
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
				this.OnPESuccessorChanging(value);
				this.SendPropertyChanging();
				this._PESuccessor = value;
				this.SendPropertyChanged("PESuccessor");
				this.OnPESuccessorChanged();
			}
		}
	}
	
	#region Parents
	[Association(Storage= "_processelementSuccessor", OtherKey="ProcessElementID", ThisKey="PESuccessor", Name="PROCESSELEMENT_PERELATION_SUCCESSOR", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	internal ProcessElement ProcessElementSuccessor
	{
		get
		{
			return this._processelementSuccessor.Entity;
		}
		set
		{
			if (((this._processelementSuccessor.Entity == value) 
						== false))
			{
				if ((this._processelementSuccessor.Entity != null))
				{
					ProcessElement previousProcessElement = this._processelementSuccessor.Entity;
					this._processelementSuccessor.Entity = null;
					previousProcessElement.PERelationSuccessor.Remove(this);
				}
				this._processelementSuccessor.Entity = value;
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


	
	[Association(Storage= "_processelementPredecessor", OtherKey="ProcessElementID", ThisKey="PEPredecessor", Name="PROCESSELEMENT_PERELATION_PREDECESSOR", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	internal ProcessElement ProcessElementPredecessor
	{
		get
		{
			return this._processelementPredecessor.Entity;
		}
		set
		{
			if (((this._processelementPredecessor.Entity == value) 
			     == false))
			{
				if ((this._processelementPredecessor.Entity != null))
				{
					ProcessElement previousProcessElement = this._processelementPredecessor.Entity;
					this._processelementPredecessor.Entity = null;
					previousProcessElement.PERelationPredecessor.Remove(this);
				}
				this._processelementPredecessor.Entity = value;
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
 