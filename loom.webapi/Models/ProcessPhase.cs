using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;


namespace loom.webapi.models
{
    
[Table(Name="LOOM.ProcessPhase")]
public partial class ProcessPhase : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private string _description;
	
	private int _processPhaseID;
	
	private EntitySet<ProcessElement> _processElement;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnProcessPhaseIDChanged();
		
		partial void OnProcessPhaseIDChanging(int value);
		#endregion
	
	
	public ProcessPhase()
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
	
	[Column(Storage="_processPhaseID", Name="ProcessPhaseID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int ProcessPhaseID
	{
		get
		{
			return this._processPhaseID;
		}
		set
		{
			if ((_processPhaseID != value))
			{
				this.OnProcessPhaseIDChanging(value);
				this.SendPropertyChanging();
				this._processPhaseID = value;
				this.SendPropertyChanged("ProcessPhaseID");
				this.OnProcessPhaseIDChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_processElement", OtherKey="ProcessPhase", ThisKey="ProcessPhaseID", Name="PROCESSELEMENT_PROCESSPHASEPROCESSELEMENT")]
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
		entity.ProcessPhaseProcessPhase = this;
	}
	
	private void ProcessElement_Detach(ProcessElement entity)
	{
		this.SendPropertyChanging();
		entity.ProcessPhaseProcessPhase = null;
	}
	#endregion
}


}