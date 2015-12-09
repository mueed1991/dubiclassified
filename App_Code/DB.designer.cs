﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dubizzle")]
public partial class DBDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Insertcategory(category instance);
  partial void Updatecategory(category instance);
  partial void Deletecategory(category instance);
  partial void Insertlocation(location instance);
  partial void Updatelocation(location instance);
  partial void Deletelocation(location instance);
  partial void Insertweb_config(web_config instance);
  partial void Updateweb_config(web_config instance);
  partial void Deleteweb_config(web_config instance);
  #endregion
	
	public DBDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["dubizzleConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DBDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DBDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<category> categories
	{
		get
		{
			return this.GetTable<category>();
		}
	}
	
	public System.Data.Linq.Table<location> locations
	{
		get
		{
			return this.GetTable<location>();
		}
	}
	
	public System.Data.Linq.Table<web_config> web_configs
	{
		get
		{
			return this.GetTable<web_config>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.categories")]
public partial class category : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _category_id;
	
	private string _category_name;
	
	private string _category_photo;
	
	private string _created_by;
	
	private System.Nullable<System.DateTime> _created_date;
	
	private string _modified_by;
	
	private System.Nullable<System.DateTime> _modified_date;
	
	private System.Nullable<bool> _deleted;
	
	private System.Nullable<int> _parent_id;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncategory_idChanging(int value);
    partial void Oncategory_idChanged();
    partial void Oncategory_nameChanging(string value);
    partial void Oncategory_nameChanged();
    partial void Oncategory_photoChanging(string value);
    partial void Oncategory_photoChanged();
    partial void Oncreated_byChanging(string value);
    partial void Oncreated_byChanged();
    partial void Oncreated_dateChanging(System.Nullable<System.DateTime> value);
    partial void Oncreated_dateChanged();
    partial void Onmodified_byChanging(string value);
    partial void Onmodified_byChanged();
    partial void Onmodified_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onmodified_dateChanged();
    partial void OndeletedChanging(System.Nullable<bool> value);
    partial void OndeletedChanged();
    partial void Onparent_idChanging(System.Nullable<int> value);
    partial void Onparent_idChanged();
    #endregion
	
	public category()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int category_id
	{
		get
		{
			return this._category_id;
		}
		set
		{
			if ((this._category_id != value))
			{
				this.Oncategory_idChanging(value);
				this.SendPropertyChanging();
				this._category_id = value;
				this.SendPropertyChanged("category_id");
				this.Oncategory_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category_name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string category_name
	{
		get
		{
			return this._category_name;
		}
		set
		{
			if ((this._category_name != value))
			{
				this.Oncategory_nameChanging(value);
				this.SendPropertyChanging();
				this._category_name = value;
				this.SendPropertyChanged("category_name");
				this.Oncategory_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category_photo", DbType="VarChar(100)")]
	public string category_photo
	{
		get
		{
			return this._category_photo;
		}
		set
		{
			if ((this._category_photo != value))
			{
				this.Oncategory_photoChanging(value);
				this.SendPropertyChanging();
				this._category_photo = value;
				this.SendPropertyChanged("category_photo");
				this.Oncategory_photoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_created_by", DbType="VarChar(20)")]
	public string created_by
	{
		get
		{
			return this._created_by;
		}
		set
		{
			if ((this._created_by != value))
			{
				this.Oncreated_byChanging(value);
				this.SendPropertyChanging();
				this._created_by = value;
				this.SendPropertyChanged("created_by");
				this.Oncreated_byChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_created_date", DbType="DateTime")]
	public System.Nullable<System.DateTime> created_date
	{
		get
		{
			return this._created_date;
		}
		set
		{
			if ((this._created_date != value))
			{
				this.Oncreated_dateChanging(value);
				this.SendPropertyChanging();
				this._created_date = value;
				this.SendPropertyChanged("created_date");
				this.Oncreated_dateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modified_by", DbType="VarChar(20)")]
	public string modified_by
	{
		get
		{
			return this._modified_by;
		}
		set
		{
			if ((this._modified_by != value))
			{
				this.Onmodified_byChanging(value);
				this.SendPropertyChanging();
				this._modified_by = value;
				this.SendPropertyChanged("modified_by");
				this.Onmodified_byChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modified_date", DbType="DateTime")]
	public System.Nullable<System.DateTime> modified_date
	{
		get
		{
			return this._modified_date;
		}
		set
		{
			if ((this._modified_date != value))
			{
				this.Onmodified_dateChanging(value);
				this.SendPropertyChanging();
				this._modified_date = value;
				this.SendPropertyChanged("modified_date");
				this.Onmodified_dateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deleted", DbType="Bit")]
	public System.Nullable<bool> deleted
	{
		get
		{
			return this._deleted;
		}
		set
		{
			if ((this._deleted != value))
			{
				this.OndeletedChanging(value);
				this.SendPropertyChanging();
				this._deleted = value;
				this.SendPropertyChanged("deleted");
				this.OndeletedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_parent_id", DbType="Int")]
	public System.Nullable<int> parent_id
	{
		get
		{
			return this._parent_id;
		}
		set
		{
			if ((this._parent_id != value))
			{
				this.Onparent_idChanging(value);
				this.SendPropertyChanging();
				this._parent_id = value;
				this.SendPropertyChanged("parent_id");
				this.Onparent_idChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.locations")]
public partial class location : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _location_id;
	
	private string _location_name;
	
	private string _location_photo;
	
	private string _created_by;
	
	private System.Nullable<System.DateTime> _created_date;
	
	private string _modified_by;
	
	private System.Nullable<System.DateTime> _modified_date;
	
	private System.Nullable<bool> _deleted;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onlocation_idChanging(int value);
    partial void Onlocation_idChanged();
    partial void Onlocation_nameChanging(string value);
    partial void Onlocation_nameChanged();
    partial void Onlocation_photoChanging(string value);
    partial void Onlocation_photoChanged();
    partial void Oncreated_byChanging(string value);
    partial void Oncreated_byChanged();
    partial void Oncreated_dateChanging(System.Nullable<System.DateTime> value);
    partial void Oncreated_dateChanged();
    partial void Onmodified_byChanging(string value);
    partial void Onmodified_byChanged();
    partial void Onmodified_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onmodified_dateChanged();
    partial void OndeletedChanging(System.Nullable<bool> value);
    partial void OndeletedChanged();
    #endregion
	
	public location()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_location_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int location_id
	{
		get
		{
			return this._location_id;
		}
		set
		{
			if ((this._location_id != value))
			{
				this.Onlocation_idChanging(value);
				this.SendPropertyChanging();
				this._location_id = value;
				this.SendPropertyChanged("location_id");
				this.Onlocation_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_location_name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string location_name
	{
		get
		{
			return this._location_name;
		}
		set
		{
			if ((this._location_name != value))
			{
				this.Onlocation_nameChanging(value);
				this.SendPropertyChanging();
				this._location_name = value;
				this.SendPropertyChanged("location_name");
				this.Onlocation_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_location_photo", DbType="VarChar(100)")]
	public string location_photo
	{
		get
		{
			return this._location_photo;
		}
		set
		{
			if ((this._location_photo != value))
			{
				this.Onlocation_photoChanging(value);
				this.SendPropertyChanging();
				this._location_photo = value;
				this.SendPropertyChanged("location_photo");
				this.Onlocation_photoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_created_by", DbType="VarChar(20)")]
	public string created_by
	{
		get
		{
			return this._created_by;
		}
		set
		{
			if ((this._created_by != value))
			{
				this.Oncreated_byChanging(value);
				this.SendPropertyChanging();
				this._created_by = value;
				this.SendPropertyChanged("created_by");
				this.Oncreated_byChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_created_date", DbType="DateTime")]
	public System.Nullable<System.DateTime> created_date
	{
		get
		{
			return this._created_date;
		}
		set
		{
			if ((this._created_date != value))
			{
				this.Oncreated_dateChanging(value);
				this.SendPropertyChanging();
				this._created_date = value;
				this.SendPropertyChanged("created_date");
				this.Oncreated_dateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modified_by", DbType="VarChar(20)")]
	public string modified_by
	{
		get
		{
			return this._modified_by;
		}
		set
		{
			if ((this._modified_by != value))
			{
				this.Onmodified_byChanging(value);
				this.SendPropertyChanging();
				this._modified_by = value;
				this.SendPropertyChanged("modified_by");
				this.Onmodified_byChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modified_date", DbType="DateTime")]
	public System.Nullable<System.DateTime> modified_date
	{
		get
		{
			return this._modified_date;
		}
		set
		{
			if ((this._modified_date != value))
			{
				this.Onmodified_dateChanging(value);
				this.SendPropertyChanging();
				this._modified_date = value;
				this.SendPropertyChanged("modified_date");
				this.Onmodified_dateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deleted", DbType="Bit")]
	public System.Nullable<bool> deleted
	{
		get
		{
			return this._deleted;
		}
		set
		{
			if ((this._deleted != value))
			{
				this.OndeletedChanging(value);
				this.SendPropertyChanging();
				this._deleted = value;
				this.SendPropertyChanged("deleted");
				this.OndeletedChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.web_config")]
public partial class web_config : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _config_id;
	
	private string _config_name;
	
	private string _config_val;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onconfig_idChanging(int value);
    partial void Onconfig_idChanged();
    partial void Onconfig_nameChanging(string value);
    partial void Onconfig_nameChanged();
    partial void Onconfig_valChanging(string value);
    partial void Onconfig_valChanged();
    #endregion
	
	public web_config()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_config_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int config_id
	{
		get
		{
			return this._config_id;
		}
		set
		{
			if ((this._config_id != value))
			{
				this.Onconfig_idChanging(value);
				this.SendPropertyChanging();
				this._config_id = value;
				this.SendPropertyChanged("config_id");
				this.Onconfig_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_config_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string config_name
	{
		get
		{
			return this._config_name;
		}
		set
		{
			if ((this._config_name != value))
			{
				this.Onconfig_nameChanging(value);
				this.SendPropertyChanging();
				this._config_name = value;
				this.SendPropertyChanged("config_name");
				this.Onconfig_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_config_val", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
	public string config_val
	{
		get
		{
			return this._config_val;
		}
		set
		{
			if ((this._config_val != value))
			{
				this.Onconfig_valChanging(value);
				this.SendPropertyChanging();
				this._config_val = value;
				this.SendPropertyChanged("config_val");
				this.Onconfig_valChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
#pragma warning restore 1591
