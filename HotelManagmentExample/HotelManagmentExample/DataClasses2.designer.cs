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

namespace HotelManagmentExample
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HotelManagmentExample")]
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertStaffDetail(StaffDetail instance);
    partial void UpdateStaffDetail(StaffDetail instance);
    partial void DeleteStaffDetail(StaffDetail instance);
    partial void InsertRegistrationDetail(RegistrationDetail instance);
    partial void UpdateRegistrationDetail(RegistrationDetail instance);
    partial void DeleteRegistrationDetail(RegistrationDetail instance);
    #endregion
		
		public DataClasses2DataContext() : 
				base(global::HotelManagmentExample.Properties.Settings.Default.HotelManagmentExampleConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<StaffDetail> StaffDetails
		{
			get
			{
				return this.GetTable<StaffDetail>();
			}
		}
		
		public System.Data.Linq.Table<RegistrationDetail> RegistrationDetails
		{
			get
			{
				return this.GetTable<RegistrationDetail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StaffDetails")]
	public partial class StaffDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Personal_Details;
		
		private string _Fimaly;
		
		private string _Educational;
		
		private string _Eperience;
		
		private string _Promotion_Details;
		
		private string _Feedback;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPersonal_DetailsChanging(string value);
    partial void OnPersonal_DetailsChanged();
    partial void OnFimalyChanging(string value);
    partial void OnFimalyChanged();
    partial void OnEducationalChanging(string value);
    partial void OnEducationalChanged();
    partial void OnEperienceChanging(string value);
    partial void OnEperienceChanged();
    partial void OnPromotion_DetailsChanging(string value);
    partial void OnPromotion_DetailsChanged();
    partial void OnFeedbackChanging(string value);
    partial void OnFeedbackChanged();
    #endregion
		
		public StaffDetail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Personal_Details", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Personal_Details
		{
			get
			{
				return this._Personal_Details;
			}
			set
			{
				if ((this._Personal_Details != value))
				{
					this.OnPersonal_DetailsChanging(value);
					this.SendPropertyChanging();
					this._Personal_Details = value;
					this.SendPropertyChanged("Personal_Details");
					this.OnPersonal_DetailsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fimaly", DbType="VarChar(50)")]
		public string Fimaly
		{
			get
			{
				return this._Fimaly;
			}
			set
			{
				if ((this._Fimaly != value))
				{
					this.OnFimalyChanging(value);
					this.SendPropertyChanging();
					this._Fimaly = value;
					this.SendPropertyChanged("Fimaly");
					this.OnFimalyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Educational", DbType="VarChar(50)")]
		public string Educational
		{
			get
			{
				return this._Educational;
			}
			set
			{
				if ((this._Educational != value))
				{
					this.OnEducationalChanging(value);
					this.SendPropertyChanging();
					this._Educational = value;
					this.SendPropertyChanged("Educational");
					this.OnEducationalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Eperience", DbType="VarChar(50)")]
		public string Eperience
		{
			get
			{
				return this._Eperience;
			}
			set
			{
				if ((this._Eperience != value))
				{
					this.OnEperienceChanging(value);
					this.SendPropertyChanging();
					this._Eperience = value;
					this.SendPropertyChanged("Eperience");
					this.OnEperienceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Promotion_Details", DbType="VarChar(50)")]
		public string Promotion_Details
		{
			get
			{
				return this._Promotion_Details;
			}
			set
			{
				if ((this._Promotion_Details != value))
				{
					this.OnPromotion_DetailsChanging(value);
					this.SendPropertyChanging();
					this._Promotion_Details = value;
					this.SendPropertyChanged("Promotion_Details");
					this.OnPromotion_DetailsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Feedback", DbType="VarChar(50)")]
		public string Feedback
		{
			get
			{
				return this._Feedback;
			}
			set
			{
				if ((this._Feedback != value))
				{
					this.OnFeedbackChanging(value);
					this.SendPropertyChanging();
					this._Feedback = value;
					this.SendPropertyChanged("Feedback");
					this.OnFeedbackChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RegistrationDetails")]
	public partial class RegistrationDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _First_Name;
		
		private string _Last_Name;
		
		private string _Contact;
		
		private string _Address;
		
		private string _Email_Address;
		
		private string _Cuntery;
		
		private string _Job_Details;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnContactChanging(string value);
    partial void OnContactChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnEmail_AddressChanging(string value);
    partial void OnEmail_AddressChanged();
    partial void OnCunteryChanging(string value);
    partial void OnCunteryChanged();
    partial void OnJob_DetailsChanging(string value);
    partial void OnJob_DetailsChanged();
    #endregion
		
		public RegistrationDetail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="VarChar(50)")]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Name", DbType="VarChar(50)")]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contact", DbType="VarChar(50)")]
		public string Contact
		{
			get
			{
				return this._Contact;
			}
			set
			{
				if ((this._Contact != value))
				{
					this.OnContactChanging(value);
					this.SendPropertyChanging();
					this._Contact = value;
					this.SendPropertyChanged("Contact");
					this.OnContactChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email_Address", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Email_Address
		{
			get
			{
				return this._Email_Address;
			}
			set
			{
				if ((this._Email_Address != value))
				{
					this.OnEmail_AddressChanging(value);
					this.SendPropertyChanging();
					this._Email_Address = value;
					this.SendPropertyChanged("Email_Address");
					this.OnEmail_AddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cuntery", DbType="VarChar(50)")]
		public string Cuntery
		{
			get
			{
				return this._Cuntery;
			}
			set
			{
				if ((this._Cuntery != value))
				{
					this.OnCunteryChanging(value);
					this.SendPropertyChanging();
					this._Cuntery = value;
					this.SendPropertyChanged("Cuntery");
					this.OnCunteryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Job_Details", DbType="VarChar(50)")]
		public string Job_Details
		{
			get
			{
				return this._Job_Details;
			}
			set
			{
				if ((this._Job_Details != value))
				{
					this.OnJob_DetailsChanging(value);
					this.SendPropertyChanging();
					this._Job_Details = value;
					this.SendPropertyChanged("Job_Details");
					this.OnJob_DetailsChanged();
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