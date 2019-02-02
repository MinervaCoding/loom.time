// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from LOOM_DB_TEST on 2019-02-01 22:31:35Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//


[Table(Name="LOOM.PERelation")]
public partial class PerElation : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<int> _pepRedecessor;
	
	private int _perElationID;
	
	private System.Nullable<int> _pesUccessor;
	
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
	
	
	public PerElation()
	{
		this.OnCreated();
	}
	
	[Column(Storage="_pepRedecessor", Name="PEPredecessor", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> PepRedecessor
	{
		get
		{
			return this._pepRedecessor;
		}
		set
		{
			if ((_pepRedecessor != value))
			{
				this.OnPepRedecessorChanging(value);
				this.SendPropertyChanging();
				this._pepRedecessor = value;
				this.SendPropertyChanged("PEPredecessor");
				this.OnPepRedecessorChanged();
			}
		}
	}
	
	[Column(Storage="_perElationID", Name="PERelationID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int PerElationID
	{
		get
		{
			return this._perElationID;
		}
		set
		{
			if ((_perElationID != value))
			{
				this.OnPerElationIDChanging(value);
				this.SendPropertyChanging();
				this._perElationID = value;
				this.SendPropertyChanged("PERelationId");
				this.OnPerElationIDChanged();
			}
		}
	}
	
	[Column(Storage="_pesUccessor", Name="PESuccessor", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> PesUccessor
	{
		get
		{
			return this._pesUccessor;
		}
		set
		{
			if ((_pesUccessor != value))
			{
				this.OnPesUccessorChanging(value);
				this.SendPropertyChanging();
				this._pesUccessor = value;
				this.SendPropertyChanged("PESuccessor");
				this.OnPesUccessorChanged();
			}
		}
	}
	
	#region Parents
	[Association(Storage="_processElement", OtherKey="ProcessElementID", ThisKey="PESuccessor", Name="PROCESSELEMENT_PERELATION_SUCCESSOR", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public ProcessElement ProcessElement
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
					previousProcessElement.PerElation.Remove(this);
				}
				this._processElement.Entity = value;
				if ((value != null))
				{
					value.PerElation.Add(this);
					_pesUccessor = value.ProcessElementID;
				}
				else
				{
					_pesUccessor = null;
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





