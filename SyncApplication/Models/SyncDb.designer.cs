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

namespace SyncApplication.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="local_db")]
	public partial class SyncDbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCalendarSyncLog(CalendarSyncLog instance);
    partial void UpdateCalendarSyncLog(CalendarSyncLog instance);
    partial void DeleteCalendarSyncLog(CalendarSyncLog instance);
    partial void InsertCalendarSyncToken(CalendarSyncToken instance);
    partial void UpdateCalendarSyncToken(CalendarSyncToken instance);
    partial void DeleteCalendarSyncToken(CalendarSyncToken instance);
    #endregion
		
		public SyncDbDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["local_dbConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SyncDbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SyncDbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SyncDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SyncDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CalendarSyncLog> CalendarSyncLogs
		{
			get
			{
				return this.GetTable<CalendarSyncLog>();
			}
		}
		
		public System.Data.Linq.Table<CalendarSyncPermission> CalendarSyncPermissions
		{
			get
			{
				return this.GetTable<CalendarSyncPermission>();
			}
		}
		
		public System.Data.Linq.Table<CalendarSyncToken> CalendarSyncTokens
		{
			get
			{
				return this.GetTable<CalendarSyncToken>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CalendarSyncLog")]
	public partial class CalendarSyncLog : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LogId;
		
		private System.Nullable<int> _TokenId;
		
		private System.Nullable<System.DateTime> _SyncDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLogIdChanging(int value);
    partial void OnLogIdChanged();
    partial void OnTokenIdChanging(System.Nullable<int> value);
    partial void OnTokenIdChanged();
    partial void OnSyncDateChanging(System.Nullable<System.DateTime> value);
    partial void OnSyncDateChanged();
    #endregion
		
		public CalendarSyncLog()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LogId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int LogId
		{
			get
			{
				return this._LogId;
			}
			set
			{
				if ((this._LogId != value))
				{
					this.OnLogIdChanging(value);
					this.SendPropertyChanging();
					this._LogId = value;
					this.SendPropertyChanged("LogId");
					this.OnLogIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TokenId", DbType="Int")]
		public System.Nullable<int> TokenId
		{
			get
			{
				return this._TokenId;
			}
			set
			{
				if ((this._TokenId != value))
				{
					this.OnTokenIdChanging(value);
					this.SendPropertyChanging();
					this._TokenId = value;
					this.SendPropertyChanged("TokenId");
					this.OnTokenIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SyncDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> SyncDate
		{
			get
			{
				return this._SyncDate;
			}
			set
			{
				if ((this._SyncDate != value))
				{
					this.OnSyncDateChanging(value);
					this.SendPropertyChanging();
					this._SyncDate = value;
					this.SendPropertyChanged("SyncDate");
					this.OnSyncDateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CalendarSyncPermission")]
	public partial class CalendarSyncPermission
	{
		
		private System.Nullable<int> _Id;
		
		private System.Nullable<int> _CompanyId;
		
		private System.Nullable<int> _AccountId;
		
		private System.Nullable<bool> _AllowGoogleSync;
		
		private System.Nullable<bool> _AllowOutlookSync;
		
		private System.Nullable<bool> _AllowOffice365Sync;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<System.DateTime> _UpdatedOn;
		
		public CalendarSyncPermission()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int")]
		public System.Nullable<int> Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyId", DbType="Int")]
		public System.Nullable<int> CompanyId
		{
			get
			{
				return this._CompanyId;
			}
			set
			{
				if ((this._CompanyId != value))
				{
					this._CompanyId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountId", DbType="Int")]
		public System.Nullable<int> AccountId
		{
			get
			{
				return this._AccountId;
			}
			set
			{
				if ((this._AccountId != value))
				{
					this._AccountId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AllowGoogleSync", DbType="Bit")]
		public System.Nullable<bool> AllowGoogleSync
		{
			get
			{
				return this._AllowGoogleSync;
			}
			set
			{
				if ((this._AllowGoogleSync != value))
				{
					this._AllowGoogleSync = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AllowOutlookSync", DbType="Bit")]
		public System.Nullable<bool> AllowOutlookSync
		{
			get
			{
				return this._AllowOutlookSync;
			}
			set
			{
				if ((this._AllowOutlookSync != value))
				{
					this._AllowOutlookSync = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AllowOffice365Sync", DbType="Bit")]
		public System.Nullable<bool> AllowOffice365Sync
		{
			get
			{
				return this._AllowOffice365Sync;
			}
			set
			{
				if ((this._AllowOffice365Sync != value))
				{
					this._AllowOffice365Sync = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this._CreatedOn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> UpdatedOn
		{
			get
			{
				return this._UpdatedOn;
			}
			set
			{
				if ((this._UpdatedOn != value))
				{
					this._UpdatedOn = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CalendarSyncToken")]
	public partial class CalendarSyncToken : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TokenId;
		
		private System.Nullable<int> _CompanyId;
		
		private System.Nullable<int> _AccountId;
		
		private string _UserEmail;
		
		private string _EmailServer;
		
		private System.Nullable<System.DateTime> _ConfigurationDate;
		
		private System.Nullable<bool> _IsSyncActive;
		
		private string _TokenType;
		
		private string _AccessToken;
		
		private string _RefreshToken;
		
		private System.Nullable<int> _TokenExpiresIn;
		
		private System.Nullable<System.DateTime> _TokenUpdatedOn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTokenIdChanging(int value);
    partial void OnTokenIdChanged();
    partial void OnCompanyIdChanging(System.Nullable<int> value);
    partial void OnCompanyIdChanged();
    partial void OnAccountIdChanging(System.Nullable<int> value);
    partial void OnAccountIdChanged();
    partial void OnUserEmailChanging(string value);
    partial void OnUserEmailChanged();
    partial void OnEmailServerChanging(string value);
    partial void OnEmailServerChanged();
    partial void OnConfigurationDateChanging(System.Nullable<System.DateTime> value);
    partial void OnConfigurationDateChanged();
    partial void OnIsSyncActiveChanging(System.Nullable<bool> value);
    partial void OnIsSyncActiveChanged();
    partial void OnTokenTypeChanging(string value);
    partial void OnTokenTypeChanged();
    partial void OnAccessTokenChanging(string value);
    partial void OnAccessTokenChanged();
    partial void OnRefreshTokenChanging(string value);
    partial void OnRefreshTokenChanged();
    partial void OnTokenExpiresInChanging(System.Nullable<int> value);
    partial void OnTokenExpiresInChanged();
    partial void OnTokenUpdatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnTokenUpdatedOnChanged();
    #endregion
		
		public CalendarSyncToken()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TokenId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TokenId
		{
			get
			{
				return this._TokenId;
			}
			set
			{
				if ((this._TokenId != value))
				{
					this.OnTokenIdChanging(value);
					this.SendPropertyChanging();
					this._TokenId = value;
					this.SendPropertyChanged("TokenId");
					this.OnTokenIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyId", DbType="Int")]
		public System.Nullable<int> CompanyId
		{
			get
			{
				return this._CompanyId;
			}
			set
			{
				if ((this._CompanyId != value))
				{
					this.OnCompanyIdChanging(value);
					this.SendPropertyChanging();
					this._CompanyId = value;
					this.SendPropertyChanged("CompanyId");
					this.OnCompanyIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountId", DbType="Int")]
		public System.Nullable<int> AccountId
		{
			get
			{
				return this._AccountId;
			}
			set
			{
				if ((this._AccountId != value))
				{
					this.OnAccountIdChanging(value);
					this.SendPropertyChanging();
					this._AccountId = value;
					this.SendPropertyChanged("AccountId");
					this.OnAccountIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserEmail", DbType="VarChar(50)")]
		public string UserEmail
		{
			get
			{
				return this._UserEmail;
			}
			set
			{
				if ((this._UserEmail != value))
				{
					this.OnUserEmailChanging(value);
					this.SendPropertyChanging();
					this._UserEmail = value;
					this.SendPropertyChanged("UserEmail");
					this.OnUserEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailServer", DbType="VarChar(50)")]
		public string EmailServer
		{
			get
			{
				return this._EmailServer;
			}
			set
			{
				if ((this._EmailServer != value))
				{
					this.OnEmailServerChanging(value);
					this.SendPropertyChanging();
					this._EmailServer = value;
					this.SendPropertyChanged("EmailServer");
					this.OnEmailServerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConfigurationDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ConfigurationDate
		{
			get
			{
				return this._ConfigurationDate;
			}
			set
			{
				if ((this._ConfigurationDate != value))
				{
					this.OnConfigurationDateChanging(value);
					this.SendPropertyChanging();
					this._ConfigurationDate = value;
					this.SendPropertyChanged("ConfigurationDate");
					this.OnConfigurationDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsSyncActive", DbType="Bit")]
		public System.Nullable<bool> IsSyncActive
		{
			get
			{
				return this._IsSyncActive;
			}
			set
			{
				if ((this._IsSyncActive != value))
				{
					this.OnIsSyncActiveChanging(value);
					this.SendPropertyChanging();
					this._IsSyncActive = value;
					this.SendPropertyChanged("IsSyncActive");
					this.OnIsSyncActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TokenType", DbType="VarChar(10)")]
		public string TokenType
		{
			get
			{
				return this._TokenType;
			}
			set
			{
				if ((this._TokenType != value))
				{
					this.OnTokenTypeChanging(value);
					this.SendPropertyChanging();
					this._TokenType = value;
					this.SendPropertyChanged("TokenType");
					this.OnTokenTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccessToken", DbType="NVarChar(1500)")]
		public string AccessToken
		{
			get
			{
				return this._AccessToken;
			}
			set
			{
				if ((this._AccessToken != value))
				{
					this.OnAccessTokenChanging(value);
					this.SendPropertyChanging();
					this._AccessToken = value;
					this.SendPropertyChanged("AccessToken");
					this.OnAccessTokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RefreshToken", DbType="NVarChar(1500)")]
		public string RefreshToken
		{
			get
			{
				return this._RefreshToken;
			}
			set
			{
				if ((this._RefreshToken != value))
				{
					this.OnRefreshTokenChanging(value);
					this.SendPropertyChanging();
					this._RefreshToken = value;
					this.SendPropertyChanged("RefreshToken");
					this.OnRefreshTokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TokenExpiresIn", DbType="Int")]
		public System.Nullable<int> TokenExpiresIn
		{
			get
			{
				return this._TokenExpiresIn;
			}
			set
			{
				if ((this._TokenExpiresIn != value))
				{
					this.OnTokenExpiresInChanging(value);
					this.SendPropertyChanging();
					this._TokenExpiresIn = value;
					this.SendPropertyChanged("TokenExpiresIn");
					this.OnTokenExpiresInChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TokenUpdatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> TokenUpdatedOn
		{
			get
			{
				return this._TokenUpdatedOn;
			}
			set
			{
				if ((this._TokenUpdatedOn != value))
				{
					this.OnTokenUpdatedOnChanging(value);
					this.SendPropertyChanging();
					this._TokenUpdatedOn = value;
					this.SendPropertyChanged("TokenUpdatedOn");
					this.OnTokenUpdatedOnChanged();
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
}
#pragma warning restore 1591
