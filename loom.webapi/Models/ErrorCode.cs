using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace loom.webapi.models
{

[Table(Name="LOOM.ErrorCode")]
public partial class ErrorCode : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private string _description;
	
	private int _errorCodeID;
	
	private string _origin;
	
	private EntitySet<Error> _error;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnErrorCodeIDChanged();
		
		partial void OnErrorCodeIDChanging(int value);
		
		partial void OnOriginChanged();
		
		partial void OnOriginChanging(string value);
		#endregion
	
	
	public ErrorCode()
	{
		_error = new EntitySet<Error>(new Action<Error>(this.Error_Attach), new Action<Error>(this.Error_Detach));
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
	
	[Column(Storage="_errorCodeID", Name="ErrorCodeID", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.OnInsert, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int ErrorCodeID
	{
		get
		{
			return this._errorCodeID;
		}
		set
		{
			if ((_errorCodeID != value))
			{
				this.OnErrorCodeIDChanging(value);
				this.SendPropertyChanging();
				this._errorCodeID = value;
				this.SendPropertyChanged("ErrorCodeID");
				this.OnErrorCodeIDChanged();
			}
		}
	}
	
	[Column(Storage="_origin", Name="Origin", DbType="varchar", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Origin
	{
		get
		{
			return this._origin;
		}
		set
		{
			if (((_origin == value) 
						== false))
			{
				this.OnOriginChanging(value);
				this.SendPropertyChanging();
				this._origin = value;
				this.SendPropertyChanged("Origin");
				this.OnOriginChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_error", OtherKey="ErrorCode", ThisKey="ErrorCodeID", Name="ERROR_ERRORCODEERROR")]
	[DebuggerNonUserCode()]
	internal EntitySet<Error> Error
	{
		get
		{
			return this._error;
		}
		set
		{
			this._error = value;
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
	private void Error_Attach(Error entity)
	{
		this.SendPropertyChanging();
		entity.ErrorCodeErrorCode = this;
	}
	
	private void Error_Detach(Error entity)
	{
		this.SendPropertyChanging();
		entity.ErrorCodeErrorCode = null;
	}
	#endregion
}

}