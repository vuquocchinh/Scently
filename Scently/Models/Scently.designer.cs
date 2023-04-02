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

namespace Scently.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Scently")]
	public partial class ScentlyDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDonHang(DonHang instance);
    partial void UpdateDonHang(DonHang instance);
    partial void DeleteDonHang(DonHang instance);
    partial void InsertSanPham(SanPham instance);
    partial void UpdateSanPham(SanPham instance);
    partial void DeleteSanPham(SanPham instance);
    partial void InsertDanhMuc(DanhMuc instance);
    partial void UpdateDanhMuc(DanhMuc instance);
    partial void DeleteDanhMuc(DanhMuc instance);
    partial void InsertChiTietDonHang(ChiTietDonHang instance);
    partial void UpdateChiTietDonHang(ChiTietDonHang instance);
    partial void DeleteChiTietDonHang(ChiTietDonHang instance);
    partial void InsertTaiKhoan(TaiKhoan instance);
    partial void UpdateTaiKhoan(TaiKhoan instance);
    partial void DeleteTaiKhoan(TaiKhoan instance);
    #endregion
		
		public ScentlyDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ScentlyDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ScentlyDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ScentlyDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}

        public ScentlyDataContext() :
                base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ScentlyConnectionString"].ConnectionString, mappingSource)
        {
            OnCreated();
        }

        public System.Data.Linq.Table<DonHang> DonHangs
		{
			get
			{
				return this.GetTable<DonHang>();
			}
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
		
		public System.Data.Linq.Table<DanhMuc> DanhMucs
		{
			get
			{
				return this.GetTable<DanhMuc>();
			}
		}
		
		public System.Data.Linq.Table<ChiTietDonHang> ChiTietDonHangs
		{
			get
			{
				return this.GetTable<ChiTietDonHang>();
			}
		}
		
		public System.Data.Linq.Table<TaiKhoan> TaiKhoans
		{
			get
			{
				return this.GetTable<TaiKhoan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DonHang")]
	public partial class DonHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _maDon;
		
		private bool _thanhToan;
		
		private bool _giaoHang;
		
		private System.DateTime _ngayDat;
		
		private System.Nullable<System.DateTime> _ngayGiao;
		
		private string _taiKhoan;
		
		private EntitySet<ChiTietDonHang> _ChiTietDonHangs;
		
		private EntityRef<TaiKhoan> _TaiKhoan1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaDonChanging(int value);
    partial void OnmaDonChanged();
    partial void OnthanhToanChanging(bool value);
    partial void OnthanhToanChanged();
    partial void OngiaoHangChanging(bool value);
    partial void OngiaoHangChanged();
    partial void OnngayDatChanging(System.DateTime value);
    partial void OnngayDatChanged();
    partial void OnngayGiaoChanging(System.Nullable<System.DateTime> value);
    partial void OnngayGiaoChanged();
    partial void OntaiKhoanChanging(string value);
    partial void OntaiKhoanChanged();
    #endregion
		
		public DonHang()
		{
			this._ChiTietDonHangs = new EntitySet<ChiTietDonHang>(new Action<ChiTietDonHang>(this.attach_ChiTietDonHangs), new Action<ChiTietDonHang>(this.detach_ChiTietDonHangs));
			this._TaiKhoan1 = default(EntityRef<TaiKhoan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maDon", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int maDon
		{
			get
			{
				return this._maDon;
			}
			set
			{
				if ((this._maDon != value))
				{
					this.OnmaDonChanging(value);
					this.SendPropertyChanging();
					this._maDon = value;
					this.SendPropertyChanged("maDon");
					this.OnmaDonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_thanhToan", DbType="Bit NOT NULL")]
		public bool thanhToan
		{
			get
			{
				return this._thanhToan;
			}
			set
			{
				if ((this._thanhToan != value))
				{
					this.OnthanhToanChanging(value);
					this.SendPropertyChanging();
					this._thanhToan = value;
					this.SendPropertyChanged("thanhToan");
					this.OnthanhToanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_giaoHang", DbType="Bit NOT NULL")]
		public bool giaoHang
		{
			get
			{
				return this._giaoHang;
			}
			set
			{
				if ((this._giaoHang != value))
				{
					this.OngiaoHangChanging(value);
					this.SendPropertyChanging();
					this._giaoHang = value;
					this.SendPropertyChanged("giaoHang");
					this.OngiaoHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDat", DbType="DateTime NOT NULL")]
		public System.DateTime ngayDat
		{
			get
			{
				return this._ngayDat;
			}
			set
			{
				if ((this._ngayDat != value))
				{
					this.OnngayDatChanging(value);
					this.SendPropertyChanging();
					this._ngayDat = value;
					this.SendPropertyChanged("ngayDat");
					this.OnngayDatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayGiao", DbType="DateTime")]
		public System.Nullable<System.DateTime> ngayGiao
		{
			get
			{
				return this._ngayGiao;
			}
			set
			{
				if ((this._ngayGiao != value))
				{
					this.OnngayGiaoChanging(value);
					this.SendPropertyChanging();
					this._ngayGiao = value;
					this.SendPropertyChanged("ngayGiao");
					this.OnngayGiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_taiKhoan", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string taiKhoan
		{
			get
			{
				return this._taiKhoan;
			}
			set
			{
				if ((this._taiKhoan != value))
				{
					if (this._TaiKhoan1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OntaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._taiKhoan = value;
					this.SendPropertyChanged("taiKhoan");
					this.OntaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonHang_ChiTietDonHang", Storage="_ChiTietDonHangs", ThisKey="maDon", OtherKey="maDon")]
		public EntitySet<ChiTietDonHang> ChiTietDonHangs
		{
			get
			{
				return this._ChiTietDonHangs;
			}
			set
			{
				this._ChiTietDonHangs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TaiKhoan_DonHang", Storage="_TaiKhoan1", ThisKey="taiKhoan", OtherKey="taiKhoan1", IsForeignKey=true)]
		public TaiKhoan TaiKhoan1
		{
			get
			{
				return this._TaiKhoan1.Entity;
			}
			set
			{
				TaiKhoan previousValue = this._TaiKhoan1.Entity;
				if (((previousValue != value) 
							|| (this._TaiKhoan1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TaiKhoan1.Entity = null;
						previousValue.DonHangs.Remove(this);
					}
					this._TaiKhoan1.Entity = value;
					if ((value != null))
					{
						value.DonHangs.Add(this);
						this._taiKhoan = value.taiKhoan1;
					}
					else
					{
						this._taiKhoan = default(string);
					}
					this.SendPropertyChanged("TaiKhoan1");
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
		
		private void attach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.DonHang = this;
		}
		
		private void detach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.DonHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idSP;
		
		private string _tenSP;
		
		private System.Nullable<int> _giaSP;
		
		private int _soLuongSP;
		
		private string _hinhAnhSP;
		
		private string _thongTinSP;
		
		private System.Nullable<System.DateTime> _ngayCapNhat;
		
		private int _idDM;
		
		private System.Nullable<double> _sale;
		
		private System.Nullable<bool> _status;
		
		private EntitySet<ChiTietDonHang> _ChiTietDonHangs;
		
		private EntityRef<DanhMuc> _DanhMuc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidSPChanging(int value);
    partial void OnidSPChanged();
    partial void OntenSPChanging(string value);
    partial void OntenSPChanged();
    partial void OngiaSPChanging(System.Nullable<int> value);
    partial void OngiaSPChanged();
    partial void OnsoLuongSPChanging(int value);
    partial void OnsoLuongSPChanged();
    partial void OnhinhAnhSPChanging(string value);
    partial void OnhinhAnhSPChanged();
    partial void OnthongTinSPChanging(string value);
    partial void OnthongTinSPChanged();
    partial void OnngayCapNhatChanging(System.Nullable<System.DateTime> value);
    partial void OnngayCapNhatChanged();
    partial void OnidDMChanging(int value);
    partial void OnidDMChanged();
    partial void OnsaleChanging(System.Nullable<double> value);
    partial void OnsaleChanged();
    partial void OnstatusChanging(System.Nullable<bool> value);
    partial void OnstatusChanged();
    #endregion
		
		public SanPham()
		{
			this._ChiTietDonHangs = new EntitySet<ChiTietDonHang>(new Action<ChiTietDonHang>(this.attach_ChiTietDonHangs), new Action<ChiTietDonHang>(this.detach_ChiTietDonHangs));
			this._DanhMuc = default(EntityRef<DanhMuc>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idSP", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idSP
		{
			get
			{
				return this._idSP;
			}
			set
			{
				if ((this._idSP != value))
				{
					this.OnidSPChanging(value);
					this.SendPropertyChanging();
					this._idSP = value;
					this.SendPropertyChanged("idSP");
					this.OnidSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenSP", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tenSP
		{
			get
			{
				return this._tenSP;
			}
			set
			{
				if ((this._tenSP != value))
				{
					this.OntenSPChanging(value);
					this.SendPropertyChanging();
					this._tenSP = value;
					this.SendPropertyChanged("tenSP");
					this.OntenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_giaSP", DbType="Int")]
		public System.Nullable<int> giaSP
		{
			get
			{
				return this._giaSP;
			}
			set
			{
				if ((this._giaSP != value))
				{
					this.OngiaSPChanging(value);
					this.SendPropertyChanging();
					this._giaSP = value;
					this.SendPropertyChanged("giaSP");
					this.OngiaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soLuongSP", DbType="Int NOT NULL")]
		public int soLuongSP
		{
			get
			{
				return this._soLuongSP;
			}
			set
			{
				if ((this._soLuongSP != value))
				{
					this.OnsoLuongSPChanging(value);
					this.SendPropertyChanging();
					this._soLuongSP = value;
					this.SendPropertyChanged("soLuongSP");
					this.OnsoLuongSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinhAnhSP", DbType="NVarChar(100)")]
		public string hinhAnhSP
		{
			get
			{
				return this._hinhAnhSP;
			}
			set
			{
				if ((this._hinhAnhSP != value))
				{
					this.OnhinhAnhSPChanging(value);
					this.SendPropertyChanging();
					this._hinhAnhSP = value;
					this.SendPropertyChanged("hinhAnhSP");
					this.OnhinhAnhSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_thongTinSP", DbType="NVarChar(MAX)")]
		public string thongTinSP
		{
			get
			{
				return this._thongTinSP;
			}
			set
			{
				if ((this._thongTinSP != value))
				{
					this.OnthongTinSPChanging(value);
					this.SendPropertyChanging();
					this._thongTinSP = value;
					this.SendPropertyChanged("thongTinSP");
					this.OnthongTinSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayCapNhat", DbType="DateTime")]
		public System.Nullable<System.DateTime> ngayCapNhat
		{
			get
			{
				return this._ngayCapNhat;
			}
			set
			{
				if ((this._ngayCapNhat != value))
				{
					this.OnngayCapNhatChanging(value);
					this.SendPropertyChanging();
					this._ngayCapNhat = value;
					this.SendPropertyChanged("ngayCapNhat");
					this.OnngayCapNhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idDM", DbType="Int NOT NULL")]
		public int idDM
		{
			get
			{
				return this._idDM;
			}
			set
			{
				if ((this._idDM != value))
				{
					if (this._DanhMuc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidDMChanging(value);
					this.SendPropertyChanging();
					this._idDM = value;
					this.SendPropertyChanged("idDM");
					this.OnidDMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sale", DbType="Float")]
		public System.Nullable<double> sale
		{
			get
			{
				return this._sale;
			}
			set
			{
				if ((this._sale != value))
				{
					this.OnsaleChanging(value);
					this.SendPropertyChanging();
					this._sale = value;
					this.SendPropertyChanged("sale");
					this.OnsaleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Bit")]
		public System.Nullable<bool> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_ChiTietDonHang", Storage="_ChiTietDonHangs", ThisKey="idSP", OtherKey="idSP")]
		public EntitySet<ChiTietDonHang> ChiTietDonHangs
		{
			get
			{
				return this._ChiTietDonHangs;
			}
			set
			{
				this._ChiTietDonHangs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DanhMuc_SanPham", Storage="_DanhMuc", ThisKey="idDM", OtherKey="idDM", IsForeignKey=true)]
		public DanhMuc DanhMuc
		{
			get
			{
				return this._DanhMuc.Entity;
			}
			set
			{
				DanhMuc previousValue = this._DanhMuc.Entity;
				if (((previousValue != value) 
							|| (this._DanhMuc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DanhMuc.Entity = null;
						previousValue.SanPhams.Remove(this);
					}
					this._DanhMuc.Entity = value;
					if ((value != null))
					{
						value.SanPhams.Add(this);
						this._idDM = value.idDM;
					}
					else
					{
						this._idDM = default(int);
					}
					this.SendPropertyChanged("DanhMuc");
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
		
		private void attach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = this;
		}
		
		private void detach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DanhMuc")]
	public partial class DanhMuc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idDM;
		
		private string _tenDM;
		
		private EntitySet<SanPham> _SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidDMChanging(int value);
    partial void OnidDMChanged();
    partial void OntenDMChanging(string value);
    partial void OntenDMChanged();
    #endregion
		
		public DanhMuc()
		{
			this._SanPhams = new EntitySet<SanPham>(new Action<SanPham>(this.attach_SanPhams), new Action<SanPham>(this.detach_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idDM", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idDM
		{
			get
			{
				return this._idDM;
			}
			set
			{
				if ((this._idDM != value))
				{
					this.OnidDMChanging(value);
					this.SendPropertyChanging();
					this._idDM = value;
					this.SendPropertyChanged("idDM");
					this.OnidDMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenDM", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tenDM
		{
			get
			{
				return this._tenDM;
			}
			set
			{
				if ((this._tenDM != value))
				{
					this.OntenDMChanging(value);
					this.SendPropertyChanging();
					this._tenDM = value;
					this.SendPropertyChanged("tenDM");
					this.OntenDMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DanhMuc_SanPham", Storage="_SanPhams", ThisKey="idDM", OtherKey="idDM")]
		public EntitySet<SanPham> SanPhams
		{
			get
			{
				return this._SanPhams;
			}
			set
			{
				this._SanPhams.Assign(value);
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
		
		private void attach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.DanhMuc = this;
		}
		
		private void detach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.DanhMuc = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietDonHang")]
	public partial class ChiTietDonHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _maDon;
		
		private int _idSP;
		
		private int _soLuongSP;
		
		private decimal _giaSP;
		
		private EntityRef<DonHang> _DonHang;
		
		private EntityRef<SanPham> _SanPham;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaDonChanging(int value);
    partial void OnmaDonChanged();
    partial void OnidSPChanging(int value);
    partial void OnidSPChanged();
    partial void OnsoLuongSPChanging(int value);
    partial void OnsoLuongSPChanged();
    partial void OngiaSPChanging(decimal value);
    partial void OngiaSPChanged();
    #endregion
		
		public ChiTietDonHang()
		{
			this._DonHang = default(EntityRef<DonHang>);
			this._SanPham = default(EntityRef<SanPham>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maDon", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int maDon
		{
			get
			{
				return this._maDon;
			}
			set
			{
				if ((this._maDon != value))
				{
					if (this._DonHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaDonChanging(value);
					this.SendPropertyChanging();
					this._maDon = value;
					this.SendPropertyChanged("maDon");
					this.OnmaDonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idSP", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idSP
		{
			get
			{
				return this._idSP;
			}
			set
			{
				if ((this._idSP != value))
				{
					if (this._SanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidSPChanging(value);
					this.SendPropertyChanging();
					this._idSP = value;
					this.SendPropertyChanged("idSP");
					this.OnidSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soLuongSP", DbType="Int NOT NULL")]
		public int soLuongSP
		{
			get
			{
				return this._soLuongSP;
			}
			set
			{
				if ((this._soLuongSP != value))
				{
					this.OnsoLuongSPChanging(value);
					this.SendPropertyChanging();
					this._soLuongSP = value;
					this.SendPropertyChanged("soLuongSP");
					this.OnsoLuongSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_giaSP", DbType="Money NOT NULL")]
		public decimal giaSP
		{
			get
			{
				return this._giaSP;
			}
			set
			{
				if ((this._giaSP != value))
				{
					this.OngiaSPChanging(value);
					this.SendPropertyChanging();
					this._giaSP = value;
					this.SendPropertyChanged("giaSP");
					this.OngiaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonHang_ChiTietDonHang", Storage="_DonHang", ThisKey="maDon", OtherKey="maDon", IsForeignKey=true)]
		public DonHang DonHang
		{
			get
			{
				return this._DonHang.Entity;
			}
			set
			{
				DonHang previousValue = this._DonHang.Entity;
				if (((previousValue != value) 
							|| (this._DonHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DonHang.Entity = null;
						previousValue.ChiTietDonHangs.Remove(this);
					}
					this._DonHang.Entity = value;
					if ((value != null))
					{
						value.ChiTietDonHangs.Add(this);
						this._maDon = value.maDon;
					}
					else
					{
						this._maDon = default(int);
					}
					this.SendPropertyChanged("DonHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_ChiTietDonHang", Storage="_SanPham", ThisKey="idSP", OtherKey="idSP", IsForeignKey=true)]
		public SanPham SanPham
		{
			get
			{
				return this._SanPham.Entity;
			}
			set
			{
				SanPham previousValue = this._SanPham.Entity;
				if (((previousValue != value) 
							|| (this._SanPham.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SanPham.Entity = null;
						previousValue.ChiTietDonHangs.Remove(this);
					}
					this._SanPham.Entity = value;
					if ((value != null))
					{
						value.ChiTietDonHangs.Add(this);
						this._idSP = value.idSP;
					}
					else
					{
						this._idSP = default(int);
					}
					this.SendPropertyChanged("SanPham");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TaiKhoan")]
	public partial class TaiKhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _taiKhoan1;
		
		private string _matKhau;
		
		private string _ten;
		
		private System.Nullable<bool> _gioiTinh;
		
		private System.Nullable<System.DateTime> _ngaySinh;
		
		private string _sdt;
		
		private string _email;
		
		private string _diaChi;
		
		private EntitySet<DonHang> _DonHangs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntaiKhoan1Changing(string value);
    partial void OntaiKhoan1Changed();
    partial void OnmatKhauChanging(string value);
    partial void OnmatKhauChanged();
    partial void OntenChanging(string value);
    partial void OntenChanged();
    partial void OngioiTinhChanging(System.Nullable<bool> value);
    partial void OngioiTinhChanged();
    partial void OnngaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnngaySinhChanged();
    partial void OnsdtChanging(string value);
    partial void OnsdtChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OndiaChiChanging(string value);
    partial void OndiaChiChanged();
    #endregion
		
		public TaiKhoan()
		{
			this._DonHangs = new EntitySet<DonHang>(new Action<DonHang>(this.attach_DonHangs), new Action<DonHang>(this.detach_DonHangs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="taiKhoan", Storage="_taiKhoan1", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string taiKhoan1
		{
			get
			{
				return this._taiKhoan1;
			}
			set
			{
				if ((this._taiKhoan1 != value))
				{
					this.OntaiKhoan1Changing(value);
					this.SendPropertyChanging();
					this._taiKhoan1 = value;
					this.SendPropertyChanged("taiKhoan1");
					this.OntaiKhoan1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matKhau", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string matKhau
		{
			get
			{
				return this._matKhau;
			}
			set
			{
				if ((this._matKhau != value))
				{
					this.OnmatKhauChanging(value);
					this.SendPropertyChanging();
					this._matKhau = value;
					this.SendPropertyChanged("matKhau");
					this.OnmatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ten", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ten
		{
			get
			{
				return this._ten;
			}
			set
			{
				if ((this._ten != value))
				{
					this.OntenChanging(value);
					this.SendPropertyChanging();
					this._ten = value;
					this.SendPropertyChanged("ten");
					this.OntenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gioiTinh", DbType="Bit")]
		public System.Nullable<bool> gioiTinh
		{
			get
			{
				return this._gioiTinh;
			}
			set
			{
				if ((this._gioiTinh != value))
				{
					this.OngioiTinhChanging(value);
					this.SendPropertyChanging();
					this._gioiTinh = value;
					this.SendPropertyChanged("gioiTinh");
					this.OngioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaySinh", DbType="Date")]
		public System.Nullable<System.DateTime> ngaySinh
		{
			get
			{
				return this._ngaySinh;
			}
			set
			{
				if ((this._ngaySinh != value))
				{
					this.OnngaySinhChanging(value);
					this.SendPropertyChanging();
					this._ngaySinh = value;
					this.SendPropertyChanged("ngaySinh");
					this.OnngaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdt", DbType="NVarChar(20)")]
		public string sdt
		{
			get
			{
				return this._sdt;
			}
			set
			{
				if ((this._sdt != value))
				{
					this.OnsdtChanging(value);
					this.SendPropertyChanging();
					this._sdt = value;
					this.SendPropertyChanged("sdt");
					this.OnsdtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diaChi", DbType="NVarChar(100)")]
		public string diaChi
		{
			get
			{
				return this._diaChi;
			}
			set
			{
				if ((this._diaChi != value))
				{
					this.OndiaChiChanging(value);
					this.SendPropertyChanging();
					this._diaChi = value;
					this.SendPropertyChanged("diaChi");
					this.OndiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TaiKhoan_DonHang", Storage="_DonHangs", ThisKey="taiKhoan1", OtherKey="taiKhoan")]
		public EntitySet<DonHang> DonHangs
		{
			get
			{
				return this._DonHangs;
			}
			set
			{
				this._DonHangs.Assign(value);
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
		
		private void attach_DonHangs(DonHang entity)
		{
			this.SendPropertyChanging();
			entity.TaiKhoan1 = this;
		}
		
		private void detach_DonHangs(DonHang entity)
		{
			this.SendPropertyChanging();
			entity.TaiKhoan1 = null;
		}
	}
}
#pragma warning restore 1591
