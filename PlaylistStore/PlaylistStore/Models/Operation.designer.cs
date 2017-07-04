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

namespace PlaylistStore.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PlaylistStore")]
	public partial class OperationDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertGenre(Genre instance);
    partial void UpdateGenre(Genre instance);
    partial void DeleteGenre(Genre instance);
    partial void InsertSong(Song instance);
    partial void UpdateSong(Song instance);
    partial void DeleteSong(Song instance);
    #endregion
		
		public OperationDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["PlaylistStoreConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public OperationDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OperationDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OperationDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OperationDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Genre> Genres
		{
			get
			{
				return this.GetTable<Genre>();
			}
		}
		
		public System.Data.Linq.Table<Song> Songs
		{
			get
			{
				return this.GetTable<Song>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Genre")]
	public partial class Genre : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Song> _Songs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Genre()
		{
			this._Songs = new EntitySet<Song>(new Action<Song>(this.attach_Songs), new Action<Song>(this.detach_Songs));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Genre_Song", Storage="_Songs", ThisKey="Id", OtherKey="GenreId")]
		public EntitySet<Song> Songs
		{
			get
			{
				return this._Songs;
			}
			set
			{
				this._Songs.Assign(value);
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
		
		private void attach_Songs(Song entity)
		{
			this.SendPropertyChanging();
			entity.Genre = this;
		}
		
		private void detach_Songs(Song entity)
		{
			this.SendPropertyChanging();
			entity.Genre = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Song")]
	public partial class Song : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _Singer;
		
		private string _Writer;
		
		private string _Year;
		
		private int _GenreId;
		
		private EntityRef<Genre> _Genre;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnSingerChanging(string value);
    partial void OnSingerChanged();
    partial void OnWriterChanging(string value);
    partial void OnWriterChanged();
    partial void OnYearChanging(string value);
    partial void OnYearChanged();
    partial void OnGenreIdChanging(int value);
    partial void OnGenreIdChanged();
    #endregion
		
		public Song()
		{
			this._Genre = default(EntityRef<Genre>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Singer", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Singer
		{
			get
			{
				return this._Singer;
			}
			set
			{
				if ((this._Singer != value))
				{
					this.OnSingerChanging(value);
					this.SendPropertyChanging();
					this._Singer = value;
					this.SendPropertyChanged("Singer");
					this.OnSingerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Writer", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Writer
		{
			get
			{
				return this._Writer;
			}
			set
			{
				if ((this._Writer != value))
				{
					this.OnWriterChanging(value);
					this.SendPropertyChanging();
					this._Writer = value;
					this.SendPropertyChanged("Writer");
					this.OnWriterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="NVarChar(4) NOT NULL", CanBeNull=false)]
		public string Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GenreId", DbType="Int NOT NULL")]
		public int GenreId
		{
			get
			{
				return this._GenreId;
			}
			set
			{
				if ((this._GenreId != value))
				{
					if (this._Genre.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGenreIdChanging(value);
					this.SendPropertyChanging();
					this._GenreId = value;
					this.SendPropertyChanged("GenreId");
					this.OnGenreIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Genre_Song", Storage="_Genre", ThisKey="GenreId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Genre Genre
		{
			get
			{
				return this._Genre.Entity;
			}
			set
			{
				Genre previousValue = this._Genre.Entity;
				if (((previousValue != value) 
							|| (this._Genre.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Genre.Entity = null;
						previousValue.Songs.Remove(this);
					}
					this._Genre.Entity = value;
					if ((value != null))
					{
						value.Songs.Add(this);
						this._GenreId = value.Id;
					}
					else
					{
						this._GenreId = default(int);
					}
					this.SendPropertyChanged("Genre");
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
