﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKhoHang.Model
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_KhoHang")]
	public partial class DataQLKDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_chi_tiet_hoa_don(tbl_chi_tiet_hoa_don instance);
    partial void Updatetbl_chi_tiet_hoa_don(tbl_chi_tiet_hoa_don instance);
    partial void Deletetbl_chi_tiet_hoa_don(tbl_chi_tiet_hoa_don instance);
    partial void Inserttbl_chi_tiet_kho(tbl_chi_tiet_kho instance);
    partial void Updatetbl_chi_tiet_kho(tbl_chi_tiet_kho instance);
    partial void Deletetbl_chi_tiet_kho(tbl_chi_tiet_kho instance);
    partial void Inserttbl_hang_hoa(tbl_hang_hoa instance);
    partial void Updatetbl_hang_hoa(tbl_hang_hoa instance);
    partial void Deletetbl_hang_hoa(tbl_hang_hoa instance);
    partial void Inserttbl_hoa_don(tbl_hoa_don instance);
    partial void Updatetbl_hoa_don(tbl_hoa_don instance);
    partial void Deletetbl_hoa_don(tbl_hoa_don instance);
    partial void Inserttbl_kho_hang(tbl_kho_hang instance);
    partial void Updatetbl_kho_hang(tbl_kho_hang instance);
    partial void Deletetbl_kho_hang(tbl_kho_hang instance);
    #endregion
		
		public DataQLKDataContext() : 
				base(global::QLKhoHang.Properties.Settings.Default.QL_KhoHangConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataQLKDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataQLKDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataQLKDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataQLKDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_chi_tiet_hoa_don> tbl_chi_tiet_hoa_dons
		{
			get
			{
				return this.GetTable<tbl_chi_tiet_hoa_don>();
			}
		}
		
		public System.Data.Linq.Table<tbl_chi_tiet_kho> tbl_chi_tiet_khos
		{
			get
			{
				return this.GetTable<tbl_chi_tiet_kho>();
			}
		}
		
		public System.Data.Linq.Table<tbl_hang_hoa> tbl_hang_hoas
		{
			get
			{
				return this.GetTable<tbl_hang_hoa>();
			}
		}
		
		public System.Data.Linq.Table<tbl_hoa_don> tbl_hoa_dons
		{
			get
			{
				return this.GetTable<tbl_hoa_don>();
			}
		}
		
		public System.Data.Linq.Table<tbl_kho_hang> tbl_kho_hangs
		{
			get
			{
				return this.GetTable<tbl_kho_hang>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_chi_tiet_hoa_don")]
	public partial class tbl_chi_tiet_hoa_don : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _cthd_id;
		
		private string _hd_id;
		
		private string _hh_id;
		
		private int _cthd_so_luong;
		
		private EntityRef<tbl_hang_hoa> _tbl_hang_hoa;
		
		private EntityRef<tbl_hoa_don> _tbl_hoa_don;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncthd_idChanging(string value);
    partial void Oncthd_idChanged();
    partial void Onhd_idChanging(string value);
    partial void Onhd_idChanged();
    partial void Onhh_idChanging(string value);
    partial void Onhh_idChanged();
    partial void Oncthd_so_luongChanging(int value);
    partial void Oncthd_so_luongChanged();
    #endregion
		
		public tbl_chi_tiet_hoa_don()
		{
			this._tbl_hang_hoa = default(EntityRef<tbl_hang_hoa>);
			this._tbl_hoa_don = default(EntityRef<tbl_hoa_don>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cthd_id", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string cthd_id
		{
			get
			{
				return this._cthd_id;
			}
			set
			{
				if ((this._cthd_id != value))
				{
					this.Oncthd_idChanging(value);
					this.SendPropertyChanging();
					this._cthd_id = value;
					this.SendPropertyChanged("cthd_id");
					this.Oncthd_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hd_id", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string hd_id
		{
			get
			{
				return this._hd_id;
			}
			set
			{
				if ((this._hd_id != value))
				{
					if (this._tbl_hoa_don.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onhd_idChanging(value);
					this.SendPropertyChanging();
					this._hd_id = value;
					this.SendPropertyChanged("hd_id");
					this.Onhd_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hh_id", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string hh_id
		{
			get
			{
				return this._hh_id;
			}
			set
			{
				if ((this._hh_id != value))
				{
					if (this._tbl_hang_hoa.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onhh_idChanging(value);
					this.SendPropertyChanging();
					this._hh_id = value;
					this.SendPropertyChanged("hh_id");
					this.Onhh_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cthd_so_luong", DbType="Int NOT NULL")]
		public int cthd_so_luong
		{
			get
			{
				return this._cthd_so_luong;
			}
			set
			{
				if ((this._cthd_so_luong != value))
				{
					this.Oncthd_so_luongChanging(value);
					this.SendPropertyChanging();
					this._cthd_so_luong = value;
					this.SendPropertyChanged("cthd_so_luong");
					this.Oncthd_so_luongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_hang_hoa_tbl_chi_tiet_hoa_don", Storage="_tbl_hang_hoa", ThisKey="hh_id", OtherKey="hh_id", IsForeignKey=true)]
		public tbl_hang_hoa tbl_hang_hoa
		{
			get
			{
				return this._tbl_hang_hoa.Entity;
			}
			set
			{
				tbl_hang_hoa previousValue = this._tbl_hang_hoa.Entity;
				if (((previousValue != value) 
							|| (this._tbl_hang_hoa.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_hang_hoa.Entity = null;
						previousValue.tbl_chi_tiet_hoa_dons.Remove(this);
					}
					this._tbl_hang_hoa.Entity = value;
					if ((value != null))
					{
						value.tbl_chi_tiet_hoa_dons.Add(this);
						this._hh_id = value.hh_id;
					}
					else
					{
						this._hh_id = default(string);
					}
					this.SendPropertyChanged("tbl_hang_hoa");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_hoa_don_tbl_chi_tiet_hoa_don", Storage="_tbl_hoa_don", ThisKey="hd_id", OtherKey="hd_id", IsForeignKey=true)]
		public tbl_hoa_don tbl_hoa_don
		{
			get
			{
				return this._tbl_hoa_don.Entity;
			}
			set
			{
				tbl_hoa_don previousValue = this._tbl_hoa_don.Entity;
				if (((previousValue != value) 
							|| (this._tbl_hoa_don.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_hoa_don.Entity = null;
						previousValue.tbl_chi_tiet_hoa_dons.Remove(this);
					}
					this._tbl_hoa_don.Entity = value;
					if ((value != null))
					{
						value.tbl_chi_tiet_hoa_dons.Add(this);
						this._hd_id = value.hd_id;
					}
					else
					{
						this._hd_id = default(string);
					}
					this.SendPropertyChanged("tbl_hoa_don");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_chi_tiet_kho")]
	public partial class tbl_chi_tiet_kho : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _kh_id;
		
		private string _hh_id;
		
		private System.DateTime _ngay_cap_nhat;
		
		private string _ct_id;
		
		private EntityRef<tbl_hang_hoa> _tbl_hang_hoa;
		
		private EntityRef<tbl_kho_hang> _tbl_kho_hang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onkh_idChanging(string value);
    partial void Onkh_idChanged();
    partial void Onhh_idChanging(string value);
    partial void Onhh_idChanged();
    partial void Onngay_cap_nhatChanging(System.DateTime value);
    partial void Onngay_cap_nhatChanged();
    partial void Onct_idChanging(string value);
    partial void Onct_idChanged();
    #endregion
		
		public tbl_chi_tiet_kho()
		{
			this._tbl_hang_hoa = default(EntityRef<tbl_hang_hoa>);
			this._tbl_kho_hang = default(EntityRef<tbl_kho_hang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kh_id", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string kh_id
		{
			get
			{
				return this._kh_id;
			}
			set
			{
				if ((this._kh_id != value))
				{
					if (this._tbl_kho_hang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onkh_idChanging(value);
					this.SendPropertyChanging();
					this._kh_id = value;
					this.SendPropertyChanged("kh_id");
					this.Onkh_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hh_id", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string hh_id
		{
			get
			{
				return this._hh_id;
			}
			set
			{
				if ((this._hh_id != value))
				{
					if (this._tbl_hang_hoa.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onhh_idChanging(value);
					this.SendPropertyChanging();
					this._hh_id = value;
					this.SendPropertyChanged("hh_id");
					this.Onhh_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngay_cap_nhat", DbType="DateTime NOT NULL")]
		public System.DateTime ngay_cap_nhat
		{
			get
			{
				return this._ngay_cap_nhat;
			}
			set
			{
				if ((this._ngay_cap_nhat != value))
				{
					this.Onngay_cap_nhatChanging(value);
					this.SendPropertyChanging();
					this._ngay_cap_nhat = value;
					this.SendPropertyChanged("ngay_cap_nhat");
					this.Onngay_cap_nhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ct_id", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ct_id
		{
			get
			{
				return this._ct_id;
			}
			set
			{
				if ((this._ct_id != value))
				{
					this.Onct_idChanging(value);
					this.SendPropertyChanging();
					this._ct_id = value;
					this.SendPropertyChanged("ct_id");
					this.Onct_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_hang_hoa_tbl_chi_tiet_kho", Storage="_tbl_hang_hoa", ThisKey="hh_id", OtherKey="hh_id", IsForeignKey=true)]
		public tbl_hang_hoa tbl_hang_hoa
		{
			get
			{
				return this._tbl_hang_hoa.Entity;
			}
			set
			{
				tbl_hang_hoa previousValue = this._tbl_hang_hoa.Entity;
				if (((previousValue != value) 
							|| (this._tbl_hang_hoa.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_hang_hoa.Entity = null;
						previousValue.tbl_chi_tiet_khos.Remove(this);
					}
					this._tbl_hang_hoa.Entity = value;
					if ((value != null))
					{
						value.tbl_chi_tiet_khos.Add(this);
						this._hh_id = value.hh_id;
					}
					else
					{
						this._hh_id = default(string);
					}
					this.SendPropertyChanged("tbl_hang_hoa");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_kho_hang_tbl_chi_tiet_kho", Storage="_tbl_kho_hang", ThisKey="kh_id", OtherKey="kh_id", IsForeignKey=true)]
		public tbl_kho_hang tbl_kho_hang
		{
			get
			{
				return this._tbl_kho_hang.Entity;
			}
			set
			{
				tbl_kho_hang previousValue = this._tbl_kho_hang.Entity;
				if (((previousValue != value) 
							|| (this._tbl_kho_hang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_kho_hang.Entity = null;
						previousValue.tbl_chi_tiet_khos.Remove(this);
					}
					this._tbl_kho_hang.Entity = value;
					if ((value != null))
					{
						value.tbl_chi_tiet_khos.Add(this);
						this._kh_id = value.kh_id;
					}
					else
					{
						this._kh_id = default(string);
					}
					this.SendPropertyChanged("tbl_kho_hang");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_hang_hoa")]
	public partial class tbl_hang_hoa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _hh_id;
		
		private string _hh_ten;
		
		private string _hh_noi_san_xuat;
		
		private string _hh_thong_tin;
		
		private System.Nullable<int> _hh_so_luong;
		
		private EntitySet<tbl_chi_tiet_hoa_don> _tbl_chi_tiet_hoa_dons;
		
		private EntitySet<tbl_chi_tiet_kho> _tbl_chi_tiet_khos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onhh_idChanging(string value);
    partial void Onhh_idChanged();
    partial void Onhh_tenChanging(string value);
    partial void Onhh_tenChanged();
    partial void Onhh_noi_san_xuatChanging(string value);
    partial void Onhh_noi_san_xuatChanged();
    partial void Onhh_thong_tinChanging(string value);
    partial void Onhh_thong_tinChanged();
    partial void Onhh_so_luongChanging(System.Nullable<int> value);
    partial void Onhh_so_luongChanged();
    #endregion
		
		public tbl_hang_hoa()
		{
			this._tbl_chi_tiet_hoa_dons = new EntitySet<tbl_chi_tiet_hoa_don>(new Action<tbl_chi_tiet_hoa_don>(this.attach_tbl_chi_tiet_hoa_dons), new Action<tbl_chi_tiet_hoa_don>(this.detach_tbl_chi_tiet_hoa_dons));
			this._tbl_chi_tiet_khos = new EntitySet<tbl_chi_tiet_kho>(new Action<tbl_chi_tiet_kho>(this.attach_tbl_chi_tiet_khos), new Action<tbl_chi_tiet_kho>(this.detach_tbl_chi_tiet_khos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hh_id", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string hh_id
		{
			get
			{
				return this._hh_id;
			}
			set
			{
				if ((this._hh_id != value))
				{
					this.Onhh_idChanging(value);
					this.SendPropertyChanging();
					this._hh_id = value;
					this.SendPropertyChanged("hh_id");
					this.Onhh_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hh_ten", DbType="NVarChar(100)")]
		public string hh_ten
		{
			get
			{
				return this._hh_ten;
			}
			set
			{
				if ((this._hh_ten != value))
				{
					this.Onhh_tenChanging(value);
					this.SendPropertyChanging();
					this._hh_ten = value;
					this.SendPropertyChanged("hh_ten");
					this.Onhh_tenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hh_noi_san_xuat", DbType="NVarChar(100)")]
		public string hh_noi_san_xuat
		{
			get
			{
				return this._hh_noi_san_xuat;
			}
			set
			{
				if ((this._hh_noi_san_xuat != value))
				{
					this.Onhh_noi_san_xuatChanging(value);
					this.SendPropertyChanging();
					this._hh_noi_san_xuat = value;
					this.SendPropertyChanged("hh_noi_san_xuat");
					this.Onhh_noi_san_xuatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hh_thong_tin", DbType="NVarChar(500)")]
		public string hh_thong_tin
		{
			get
			{
				return this._hh_thong_tin;
			}
			set
			{
				if ((this._hh_thong_tin != value))
				{
					this.Onhh_thong_tinChanging(value);
					this.SendPropertyChanging();
					this._hh_thong_tin = value;
					this.SendPropertyChanged("hh_thong_tin");
					this.Onhh_thong_tinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hh_so_luong", DbType="Int")]
		public System.Nullable<int> hh_so_luong
		{
			get
			{
				return this._hh_so_luong;
			}
			set
			{
				if ((this._hh_so_luong != value))
				{
					this.Onhh_so_luongChanging(value);
					this.SendPropertyChanging();
					this._hh_so_luong = value;
					this.SendPropertyChanged("hh_so_luong");
					this.Onhh_so_luongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_hang_hoa_tbl_chi_tiet_hoa_don", Storage="_tbl_chi_tiet_hoa_dons", ThisKey="hh_id", OtherKey="hh_id")]
		public EntitySet<tbl_chi_tiet_hoa_don> tbl_chi_tiet_hoa_dons
		{
			get
			{
				return this._tbl_chi_tiet_hoa_dons;
			}
			set
			{
				this._tbl_chi_tiet_hoa_dons.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_hang_hoa_tbl_chi_tiet_kho", Storage="_tbl_chi_tiet_khos", ThisKey="hh_id", OtherKey="hh_id")]
		public EntitySet<tbl_chi_tiet_kho> tbl_chi_tiet_khos
		{
			get
			{
				return this._tbl_chi_tiet_khos;
			}
			set
			{
				this._tbl_chi_tiet_khos.Assign(value);
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
		
		private void attach_tbl_chi_tiet_hoa_dons(tbl_chi_tiet_hoa_don entity)
		{
			this.SendPropertyChanging();
			entity.tbl_hang_hoa = this;
		}
		
		private void detach_tbl_chi_tiet_hoa_dons(tbl_chi_tiet_hoa_don entity)
		{
			this.SendPropertyChanging();
			entity.tbl_hang_hoa = null;
		}
		
		private void attach_tbl_chi_tiet_khos(tbl_chi_tiet_kho entity)
		{
			this.SendPropertyChanging();
			entity.tbl_hang_hoa = this;
		}
		
		private void detach_tbl_chi_tiet_khos(tbl_chi_tiet_kho entity)
		{
			this.SendPropertyChanging();
			entity.tbl_hang_hoa = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_hoa_don")]
	public partial class tbl_hoa_don : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _hd_id;
		
		private string _kh_id;
		
		private string _hd_loai;
		
		private System.Nullable<System.DateTime> _hd_ngay_lap;
		
		private string _hd_nv;
		
		private EntitySet<tbl_chi_tiet_hoa_don> _tbl_chi_tiet_hoa_dons;
		
		private EntityRef<tbl_kho_hang> _tbl_kho_hang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onhd_idChanging(string value);
    partial void Onhd_idChanged();
    partial void Onkh_idChanging(string value);
    partial void Onkh_idChanged();
    partial void Onhd_loaiChanging(string value);
    partial void Onhd_loaiChanged();
    partial void Onhd_ngay_lapChanging(System.Nullable<System.DateTime> value);
    partial void Onhd_ngay_lapChanged();
    partial void Onhd_nvChanging(string value);
    partial void Onhd_nvChanged();
    #endregion
		
		public tbl_hoa_don()
		{
			this._tbl_chi_tiet_hoa_dons = new EntitySet<tbl_chi_tiet_hoa_don>(new Action<tbl_chi_tiet_hoa_don>(this.attach_tbl_chi_tiet_hoa_dons), new Action<tbl_chi_tiet_hoa_don>(this.detach_tbl_chi_tiet_hoa_dons));
			this._tbl_kho_hang = default(EntityRef<tbl_kho_hang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hd_id", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string hd_id
		{
			get
			{
				return this._hd_id;
			}
			set
			{
				if ((this._hd_id != value))
				{
					this.Onhd_idChanging(value);
					this.SendPropertyChanging();
					this._hd_id = value;
					this.SendPropertyChanged("hd_id");
					this.Onhd_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kh_id", DbType="VarChar(10)")]
		public string kh_id
		{
			get
			{
				return this._kh_id;
			}
			set
			{
				if ((this._kh_id != value))
				{
					if (this._tbl_kho_hang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onkh_idChanging(value);
					this.SendPropertyChanging();
					this._kh_id = value;
					this.SendPropertyChanged("kh_id");
					this.Onkh_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hd_loai", DbType="NVarChar(20)")]
		public string hd_loai
		{
			get
			{
				return this._hd_loai;
			}
			set
			{
				if ((this._hd_loai != value))
				{
					this.Onhd_loaiChanging(value);
					this.SendPropertyChanging();
					this._hd_loai = value;
					this.SendPropertyChanged("hd_loai");
					this.Onhd_loaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hd_ngay_lap", DbType="DateTime")]
		public System.Nullable<System.DateTime> hd_ngay_lap
		{
			get
			{
				return this._hd_ngay_lap;
			}
			set
			{
				if ((this._hd_ngay_lap != value))
				{
					this.Onhd_ngay_lapChanging(value);
					this.SendPropertyChanging();
					this._hd_ngay_lap = value;
					this.SendPropertyChanged("hd_ngay_lap");
					this.Onhd_ngay_lapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hd_nv", DbType="NVarChar(1)")]
		public string hd_nv
		{
			get
			{
				return this._hd_nv;
			}
			set
			{
				if ((this._hd_nv != value))
				{
					this.Onhd_nvChanging(value);
					this.SendPropertyChanging();
					this._hd_nv = value;
					this.SendPropertyChanged("hd_nv");
					this.Onhd_nvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_hoa_don_tbl_chi_tiet_hoa_don", Storage="_tbl_chi_tiet_hoa_dons", ThisKey="hd_id", OtherKey="hd_id")]
		public EntitySet<tbl_chi_tiet_hoa_don> tbl_chi_tiet_hoa_dons
		{
			get
			{
				return this._tbl_chi_tiet_hoa_dons;
			}
			set
			{
				this._tbl_chi_tiet_hoa_dons.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_kho_hang_tbl_hoa_don", Storage="_tbl_kho_hang", ThisKey="kh_id", OtherKey="kh_id", IsForeignKey=true)]
		public tbl_kho_hang tbl_kho_hang
		{
			get
			{
				return this._tbl_kho_hang.Entity;
			}
			set
			{
				tbl_kho_hang previousValue = this._tbl_kho_hang.Entity;
				if (((previousValue != value) 
							|| (this._tbl_kho_hang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_kho_hang.Entity = null;
						previousValue.tbl_hoa_dons.Remove(this);
					}
					this._tbl_kho_hang.Entity = value;
					if ((value != null))
					{
						value.tbl_hoa_dons.Add(this);
						this._kh_id = value.kh_id;
					}
					else
					{
						this._kh_id = default(string);
					}
					this.SendPropertyChanged("tbl_kho_hang");
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
		
		private void attach_tbl_chi_tiet_hoa_dons(tbl_chi_tiet_hoa_don entity)
		{
			this.SendPropertyChanging();
			entity.tbl_hoa_don = this;
		}
		
		private void detach_tbl_chi_tiet_hoa_dons(tbl_chi_tiet_hoa_don entity)
		{
			this.SendPropertyChanging();
			entity.tbl_hoa_don = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_kho_hang")]
	public partial class tbl_kho_hang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _kh_id;
		
		private string _kh_dia_chi;
		
		private string _kh_quan_ly;
		
		private int _kh_suc_chua;
		
		private EntitySet<tbl_chi_tiet_kho> _tbl_chi_tiet_khos;
		
		private EntitySet<tbl_hoa_don> _tbl_hoa_dons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onkh_idChanging(string value);
    partial void Onkh_idChanged();
    partial void Onkh_dia_chiChanging(string value);
    partial void Onkh_dia_chiChanged();
    partial void Onkh_quan_lyChanging(string value);
    partial void Onkh_quan_lyChanged();
    partial void Onkh_suc_chuaChanging(int value);
    partial void Onkh_suc_chuaChanged();
    #endregion
		
		public tbl_kho_hang()
		{
			this._tbl_chi_tiet_khos = new EntitySet<tbl_chi_tiet_kho>(new Action<tbl_chi_tiet_kho>(this.attach_tbl_chi_tiet_khos), new Action<tbl_chi_tiet_kho>(this.detach_tbl_chi_tiet_khos));
			this._tbl_hoa_dons = new EntitySet<tbl_hoa_don>(new Action<tbl_hoa_don>(this.attach_tbl_hoa_dons), new Action<tbl_hoa_don>(this.detach_tbl_hoa_dons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kh_id", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string kh_id
		{
			get
			{
				return this._kh_id;
			}
			set
			{
				if ((this._kh_id != value))
				{
					this.Onkh_idChanging(value);
					this.SendPropertyChanging();
					this._kh_id = value;
					this.SendPropertyChanged("kh_id");
					this.Onkh_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kh_dia_chi", DbType="NVarChar(70) NOT NULL", CanBeNull=false)]
		public string kh_dia_chi
		{
			get
			{
				return this._kh_dia_chi;
			}
			set
			{
				if ((this._kh_dia_chi != value))
				{
					this.Onkh_dia_chiChanging(value);
					this.SendPropertyChanging();
					this._kh_dia_chi = value;
					this.SendPropertyChanged("kh_dia_chi");
					this.Onkh_dia_chiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kh_quan_ly", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string kh_quan_ly
		{
			get
			{
				return this._kh_quan_ly;
			}
			set
			{
				if ((this._kh_quan_ly != value))
				{
					this.Onkh_quan_lyChanging(value);
					this.SendPropertyChanging();
					this._kh_quan_ly = value;
					this.SendPropertyChanged("kh_quan_ly");
					this.Onkh_quan_lyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kh_suc_chua", DbType="Int NOT NULL")]
		public int kh_suc_chua
		{
			get
			{
				return this._kh_suc_chua;
			}
			set
			{
				if ((this._kh_suc_chua != value))
				{
					this.Onkh_suc_chuaChanging(value);
					this.SendPropertyChanging();
					this._kh_suc_chua = value;
					this.SendPropertyChanged("kh_suc_chua");
					this.Onkh_suc_chuaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_kho_hang_tbl_chi_tiet_kho", Storage="_tbl_chi_tiet_khos", ThisKey="kh_id", OtherKey="kh_id")]
		public EntitySet<tbl_chi_tiet_kho> tbl_chi_tiet_khos
		{
			get
			{
				return this._tbl_chi_tiet_khos;
			}
			set
			{
				this._tbl_chi_tiet_khos.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_kho_hang_tbl_hoa_don", Storage="_tbl_hoa_dons", ThisKey="kh_id", OtherKey="kh_id")]
		public EntitySet<tbl_hoa_don> tbl_hoa_dons
		{
			get
			{
				return this._tbl_hoa_dons;
			}
			set
			{
				this._tbl_hoa_dons.Assign(value);
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
		
		private void attach_tbl_chi_tiet_khos(tbl_chi_tiet_kho entity)
		{
			this.SendPropertyChanging();
			entity.tbl_kho_hang = this;
		}
		
		private void detach_tbl_chi_tiet_khos(tbl_chi_tiet_kho entity)
		{
			this.SendPropertyChanging();
			entity.tbl_kho_hang = null;
		}
		
		private void attach_tbl_hoa_dons(tbl_hoa_don entity)
		{
			this.SendPropertyChanging();
			entity.tbl_kho_hang = this;
		}
		
		private void detach_tbl_hoa_dons(tbl_hoa_don entity)
		{
			this.SendPropertyChanging();
			entity.tbl_kho_hang = null;
		}
	}
}
#pragma warning restore 1591
