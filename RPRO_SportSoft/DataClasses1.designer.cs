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

namespace RPRO_SportSoft
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SportSoftDb")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCourt(Court instance);
    partial void UpdateCourt(Court instance);
    partial void DeleteCourt(Court instance);
    partial void InsertSport(Sport instance);
    partial void UpdateSport(Sport instance);
    partial void DeleteSport(Sport instance);
    partial void InsertReservation(Reservation instance);
    partial void UpdateReservation(Reservation instance);
    partial void DeleteReservation(Reservation instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertPriceList(PriceList instance);
    partial void UpdatePriceList(PriceList instance);
    partial void DeletePriceList(PriceList instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SportSoftDbConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Court> Courts
		{
			get
			{
				return this.GetTable<Court>();
			}
		}
		
		public System.Data.Linq.Table<Sport> Sports
		{
			get
			{
				return this.GetTable<Sport>();
			}
		}
		
		public System.Data.Linq.Table<Reservation> Reservations
		{
			get
			{
				return this.GetTable<Reservation>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<PriceList> PriceLists
		{
			get
			{
				return this.GetTable<PriceList>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Courts")]
	public partial class Court : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private int _Sports_Id;
		
		private int _PriceLists_Id;
		
		private EntitySet<Reservation> _Reservations;
		
		private EntityRef<Sport> _Sport;
		
		private EntityRef<PriceList> _PriceList;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSports_IdChanging(int value);
    partial void OnSports_IdChanged();
    partial void OnPriceLists_IdChanging(int value);
    partial void OnPriceLists_IdChanged();
    #endregion
		
		public Court()
		{
			this._Reservations = new EntitySet<Reservation>(new Action<Reservation>(this.attach_Reservations), new Action<Reservation>(this.detach_Reservations));
			this._Sport = default(EntityRef<Sport>);
			this._PriceList = default(EntityRef<PriceList>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sports_Id", DbType="Int NOT NULL")]
		public int Sports_Id
		{
			get
			{
				return this._Sports_Id;
			}
			set
			{
				if ((this._Sports_Id != value))
				{
					if (this._Sport.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSports_IdChanging(value);
					this.SendPropertyChanging();
					this._Sports_Id = value;
					this.SendPropertyChanged("Sports_Id");
					this.OnSports_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PriceLists_Id")]
		public int PriceLists_Id
		{
			get
			{
				return this._PriceLists_Id;
			}
			set
			{
				if ((this._PriceLists_Id != value))
				{
					if (this._PriceList.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPriceLists_IdChanging(value);
					this.SendPropertyChanging();
					this._PriceLists_Id = value;
					this.SendPropertyChanged("PriceLists_Id");
					this.OnPriceLists_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Court_Reservation", Storage="_Reservations", ThisKey="Id", OtherKey="Courts_Id")]
		public EntitySet<Reservation> Reservations
		{
			get
			{
				return this._Reservations;
			}
			set
			{
				this._Reservations.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sport_Court", Storage="_Sport", ThisKey="Sports_Id", OtherKey="Id", IsForeignKey=true)]
		public Sport Sport
		{
			get
			{
				return this._Sport.Entity;
			}
			set
			{
				Sport previousValue = this._Sport.Entity;
				if (((previousValue != value) 
							|| (this._Sport.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sport.Entity = null;
						previousValue.Courts.Remove(this);
					}
					this._Sport.Entity = value;
					if ((value != null))
					{
						value.Courts.Add(this);
						this._Sports_Id = value.Id;
					}
					else
					{
						this._Sports_Id = default(int);
					}
					this.SendPropertyChanged("Sport");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PriceList_Court", Storage="_PriceList", ThisKey="PriceLists_Id", OtherKey="Id", IsForeignKey=true)]
		public PriceList PriceList
		{
			get
			{
				return this._PriceList.Entity;
			}
			set
			{
				PriceList previousValue = this._PriceList.Entity;
				if (((previousValue != value) 
							|| (this._PriceList.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PriceList.Entity = null;
						previousValue.Courts.Remove(this);
					}
					this._PriceList.Entity = value;
					if ((value != null))
					{
						value.Courts.Add(this);
						this._PriceLists_Id = value.Id;
					}
					else
					{
						this._PriceLists_Id = default(int);
					}
					this.SendPropertyChanged("PriceList");
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
		
		private void attach_Reservations(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.Court = this;
		}
		
		private void detach_Reservations(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.Court = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sports")]
	public partial class Sport : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Court> _Courts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Sport()
		{
			this._Courts = new EntitySet<Court>(new Action<Court>(this.attach_Courts), new Action<Court>(this.detach_Courts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sport_Court", Storage="_Courts", ThisKey="Id", OtherKey="Sports_Id")]
		public EntitySet<Court> Courts
		{
			get
			{
				return this._Courts;
			}
			set
			{
				this._Courts.Assign(value);
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
		
		private void attach_Courts(Court entity)
		{
			this.SendPropertyChanging();
			entity.Sport = this;
		}
		
		private void detach_Courts(Court entity)
		{
			this.SendPropertyChanging();
			entity.Sport = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Reservation")]
	public partial class Reservation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Courts_Id;
		
		private System.Nullable<System.DateTime> _DateReservation;
		
		private System.Nullable<System.TimeSpan> _TimeReservation;
		
		private EntityRef<Court> _Court;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCourts_IdChanging(int value);
    partial void OnCourts_IdChanged();
    partial void OnDateReservationChanging(System.Nullable<System.DateTime> value);
    partial void OnDateReservationChanged();
    partial void OnTimeReservationChanging(System.Nullable<System.TimeSpan> value);
    partial void OnTimeReservationChanged();
    #endregion
		
		public Reservation()
		{
			this._Court = default(EntityRef<Court>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Courts_Id", DbType="Int NOT NULL")]
		public int Courts_Id
		{
			get
			{
				return this._Courts_Id;
			}
			set
			{
				if ((this._Courts_Id != value))
				{
					if (this._Court.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCourts_IdChanging(value);
					this.SendPropertyChanging();
					this._Courts_Id = value;
					this.SendPropertyChanged("Courts_Id");
					this.OnCourts_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateReservation", DbType="Date")]
		public System.Nullable<System.DateTime> DateReservation
		{
			get
			{
				return this._DateReservation;
			}
			set
			{
				if ((this._DateReservation != value))
				{
					this.OnDateReservationChanging(value);
					this.SendPropertyChanging();
					this._DateReservation = value;
					this.SendPropertyChanged("DateReservation");
					this.OnDateReservationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeReservation", DbType="Time")]
		public System.Nullable<System.TimeSpan> TimeReservation
		{
			get
			{
				return this._TimeReservation;
			}
			set
			{
				if ((this._TimeReservation != value))
				{
					this.OnTimeReservationChanging(value);
					this.SendPropertyChanging();
					this._TimeReservation = value;
					this.SendPropertyChanged("TimeReservation");
					this.OnTimeReservationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Court_Reservation", Storage="_Court", ThisKey="Courts_Id", OtherKey="Id", IsForeignKey=true)]
		public Court Court
		{
			get
			{
				return this._Court.Entity;
			}
			set
			{
				Court previousValue = this._Court.Entity;
				if (((previousValue != value) 
							|| (this._Court.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Court.Entity = null;
						previousValue.Reservations.Remove(this);
					}
					this._Court.Entity = value;
					if ((value != null))
					{
						value.Reservations.Add(this);
						this._Courts_Id = value.Id;
					}
					else
					{
						this._Courts_Id = default(int);
					}
					this.SendPropertyChanged("Court");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.User")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Email;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(1) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PriceLists")]
	public partial class PriceList : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.DateTime _Date;
		
		private int _Price;
		
		private EntitySet<Court> _Courts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnPriceChanging(int value);
    partial void OnPriceChanged();
    #endregion
		
		public PriceList()
		{
			this._Courts = new EntitySet<Court>(new Action<Court>(this.attach_Courts), new Action<Court>(this.detach_Courts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="INT NOT NULL")]
		public int Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PriceList_Court", Storage="_Courts", ThisKey="Id", OtherKey="PriceLists_Id")]
		public EntitySet<Court> Courts
		{
			get
			{
				return this._Courts;
			}
			set
			{
				this._Courts.Assign(value);
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
		
		private void attach_Courts(Court entity)
		{
			this.SendPropertyChanging();
			entity.PriceList = this;
		}
		
		private void detach_Courts(Court entity)
		{
			this.SendPropertyChanging();
			entity.PriceList = null;
		}
	}
}
#pragma warning restore 1591
