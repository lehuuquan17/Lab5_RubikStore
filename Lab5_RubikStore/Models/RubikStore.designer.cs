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

namespace Lab5_RubikStore.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="RubikStore")]
	public partial class RubikStoreDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChiTietDonHang(ChiTietDonHang instance);
    partial void UpdateChiTietDonHang(ChiTietDonHang instance);
    partial void DeleteChiTietDonHang(ChiTietDonHang instance);
    partial void InsertDonHang(DonHang instance);
    partial void UpdateDonHang(DonHang instance);
    partial void DeleteDonHang(DonHang instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertLoai(Loai instance);
    partial void UpdateLoai(Loai instance);
    partial void DeleteLoai(Loai instance);
    partial void InsertRubik(Rubik instance);
    partial void UpdateRubik(Rubik instance);
    partial void DeleteRubik(Rubik instance);
    #endregion
		
		public RubikStoreDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["RubikStoreConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public RubikStoreDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RubikStoreDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RubikStoreDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RubikStoreDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ChiTietDonHang> ChiTietDonHangs
		{
			get
			{
				return this.GetTable<ChiTietDonHang>();
			}
		}
		
		public System.Data.Linq.Table<DonHang> DonHangs
		{
			get
			{
				return this.GetTable<DonHang>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<Loai> Loais
		{
			get
			{
				return this.GetTable<Loai>();
			}
		}
		
		public System.Data.Linq.Table<Rubik> Rubiks
		{
			get
			{
				return this.GetTable<Rubik>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietDonHang")]
	public partial class ChiTietDonHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _madon;
		
		private int _id;
		
		private System.Nullable<int> _soluong;
		
		private System.Nullable<decimal> _gia;
		
		private EntityRef<DonHang> _DonHang;
		
		private EntityRef<Rubik> _Rubik;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmadonChanging(int value);
    partial void OnmadonChanged();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnsoluongChanging(System.Nullable<int> value);
    partial void OnsoluongChanged();
    partial void OngiaChanging(System.Nullable<decimal> value);
    partial void OngiaChanged();
    #endregion
		
		public ChiTietDonHang()
		{
			this._DonHang = default(EntityRef<DonHang>);
			this._Rubik = default(EntityRef<Rubik>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_madon", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int madon
		{
			get
			{
				return this._madon;
			}
			set
			{
				if ((this._madon != value))
				{
					if (this._DonHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmadonChanging(value);
					this.SendPropertyChanging();
					this._madon = value;
					this.SendPropertyChanged("madon");
					this.OnmadonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					if (this._Rubik.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soluong", DbType="Int")]
		public System.Nullable<int> soluong
		{
			get
			{
				return this._soluong;
			}
			set
			{
				if ((this._soluong != value))
				{
					this.OnsoluongChanging(value);
					this.SendPropertyChanging();
					this._soluong = value;
					this.SendPropertyChanged("soluong");
					this.OnsoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> gia
		{
			get
			{
				return this._gia;
			}
			set
			{
				if ((this._gia != value))
				{
					this.OngiaChanging(value);
					this.SendPropertyChanging();
					this._gia = value;
					this.SendPropertyChanged("gia");
					this.OngiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonHang_ChiTietDonHang", Storage="_DonHang", ThisKey="madon", OtherKey="madon", IsForeignKey=true)]
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
						this._madon = value.madon;
					}
					else
					{
						this._madon = default(int);
					}
					this.SendPropertyChanged("DonHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rubik_ChiTietDonHang", Storage="_Rubik", ThisKey="id", OtherKey="id", IsForeignKey=true)]
		public Rubik Rubik
		{
			get
			{
				return this._Rubik.Entity;
			}
			set
			{
				Rubik previousValue = this._Rubik.Entity;
				if (((previousValue != value) 
							|| (this._Rubik.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Rubik.Entity = null;
						previousValue.ChiTietDonHangs.Remove(this);
					}
					this._Rubik.Entity = value;
					if ((value != null))
					{
						value.ChiTietDonHangs.Add(this);
						this._id = value.id;
					}
					else
					{
						this._id = default(int);
					}
					this.SendPropertyChanged("Rubik");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DonHang")]
	public partial class DonHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _madon;
		
		private System.Nullable<bool> _thanhtoan;
		
		private System.Nullable<bool> _giaohang;
		
		private System.Nullable<System.DateTime> _ngaydat;
		
		private System.Nullable<System.DateTime> _ngaygiao;
		
		private System.Nullable<int> _makh;
		
		private EntitySet<ChiTietDonHang> _ChiTietDonHangs;
		
		private EntityRef<KhachHang> _KhachHang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmadonChanging(int value);
    partial void OnmadonChanged();
    partial void OnthanhtoanChanging(System.Nullable<bool> value);
    partial void OnthanhtoanChanged();
    partial void OngiaohangChanging(System.Nullable<bool> value);
    partial void OngiaohangChanged();
    partial void OnngaydatChanging(System.Nullable<System.DateTime> value);
    partial void OnngaydatChanged();
    partial void OnngaygiaoChanging(System.Nullable<System.DateTime> value);
    partial void OnngaygiaoChanged();
    partial void OnmakhChanging(System.Nullable<int> value);
    partial void OnmakhChanged();
    #endregion
		
		public DonHang()
		{
			this._ChiTietDonHangs = new EntitySet<ChiTietDonHang>(new Action<ChiTietDonHang>(this.attach_ChiTietDonHangs), new Action<ChiTietDonHang>(this.detach_ChiTietDonHangs));
			this._KhachHang = default(EntityRef<KhachHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_madon", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int madon
		{
			get
			{
				return this._madon;
			}
			set
			{
				if ((this._madon != value))
				{
					this.OnmadonChanging(value);
					this.SendPropertyChanging();
					this._madon = value;
					this.SendPropertyChanged("madon");
					this.OnmadonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_thanhtoan", DbType="Bit")]
		public System.Nullable<bool> thanhtoan
		{
			get
			{
				return this._thanhtoan;
			}
			set
			{
				if ((this._thanhtoan != value))
				{
					this.OnthanhtoanChanging(value);
					this.SendPropertyChanging();
					this._thanhtoan = value;
					this.SendPropertyChanged("thanhtoan");
					this.OnthanhtoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_giaohang", DbType="Bit")]
		public System.Nullable<bool> giaohang
		{
			get
			{
				return this._giaohang;
			}
			set
			{
				if ((this._giaohang != value))
				{
					this.OngiaohangChanging(value);
					this.SendPropertyChanging();
					this._giaohang = value;
					this.SendPropertyChanged("giaohang");
					this.OngiaohangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaydat", DbType="Date")]
		public System.Nullable<System.DateTime> ngaydat
		{
			get
			{
				return this._ngaydat;
			}
			set
			{
				if ((this._ngaydat != value))
				{
					this.OnngaydatChanging(value);
					this.SendPropertyChanging();
					this._ngaydat = value;
					this.SendPropertyChanged("ngaydat");
					this.OnngaydatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaygiao", DbType="Date")]
		public System.Nullable<System.DateTime> ngaygiao
		{
			get
			{
				return this._ngaygiao;
			}
			set
			{
				if ((this._ngaygiao != value))
				{
					this.OnngaygiaoChanging(value);
					this.SendPropertyChanging();
					this._ngaygiao = value;
					this.SendPropertyChanged("ngaygiao");
					this.OnngaygiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_makh", DbType="Int")]
		public System.Nullable<int> makh
		{
			get
			{
				return this._makh;
			}
			set
			{
				if ((this._makh != value))
				{
					if (this._KhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmakhChanging(value);
					this.SendPropertyChanging();
					this._makh = value;
					this.SendPropertyChanged("makh");
					this.OnmakhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonHang_ChiTietDonHang", Storage="_ChiTietDonHangs", ThisKey="madon", OtherKey="madon")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_DonHang", Storage="_KhachHang", ThisKey="makh", OtherKey="makh", IsForeignKey=true)]
		public KhachHang KhachHang
		{
			get
			{
				return this._KhachHang.Entity;
			}
			set
			{
				KhachHang previousValue = this._KhachHang.Entity;
				if (((previousValue != value) 
							|| (this._KhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhachHang.Entity = null;
						previousValue.DonHangs.Remove(this);
					}
					this._KhachHang.Entity = value;
					if ((value != null))
					{
						value.DonHangs.Add(this);
						this._makh = value.makh;
					}
					else
					{
						this._makh = default(Nullable<int>);
					}
					this.SendPropertyChanged("KhachHang");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _makh;
		
		private string _hoten;
		
		private string _tendangnhap;
		
		private string _matkhau;
		
		private string _email;
		
		private string _diachi;
		
		private string _dienthoai;
		
		private System.Nullable<System.DateTime> _ngaysinh;
		
		private EntitySet<DonHang> _DonHangs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmakhChanging(int value);
    partial void OnmakhChanged();
    partial void OnhotenChanging(string value);
    partial void OnhotenChanged();
    partial void OntendangnhapChanging(string value);
    partial void OntendangnhapChanged();
    partial void OnmatkhauChanging(string value);
    partial void OnmatkhauChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OndiachiChanging(string value);
    partial void OndiachiChanged();
    partial void OndienthoaiChanging(string value);
    partial void OndienthoaiChanged();
    partial void OnngaysinhChanging(System.Nullable<System.DateTime> value);
    partial void OnngaysinhChanged();
    #endregion
		
		public KhachHang()
		{
			this._DonHangs = new EntitySet<DonHang>(new Action<DonHang>(this.attach_DonHangs), new Action<DonHang>(this.detach_DonHangs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_makh", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int makh
		{
			get
			{
				return this._makh;
			}
			set
			{
				if ((this._makh != value))
				{
					this.OnmakhChanging(value);
					this.SendPropertyChanging();
					this._makh = value;
					this.SendPropertyChanged("makh");
					this.OnmakhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hoten", DbType="NVarChar(50)")]
		public string hoten
		{
			get
			{
				return this._hoten;
			}
			set
			{
				if ((this._hoten != value))
				{
					this.OnhotenChanging(value);
					this.SendPropertyChanging();
					this._hoten = value;
					this.SendPropertyChanged("hoten");
					this.OnhotenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tendangnhap", DbType="VarChar(20)")]
		public string tendangnhap
		{
			get
			{
				return this._tendangnhap;
			}
			set
			{
				if ((this._tendangnhap != value))
				{
					this.OntendangnhapChanging(value);
					this.SendPropertyChanging();
					this._tendangnhap = value;
					this.SendPropertyChanged("tendangnhap");
					this.OntendangnhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matkhau", DbType="VarChar(10)")]
		public string matkhau
		{
			get
			{
				return this._matkhau;
			}
			set
			{
				if ((this._matkhau != value))
				{
					this.OnmatkhauChanging(value);
					this.SendPropertyChanging();
					this._matkhau = value;
					this.SendPropertyChanged("matkhau");
					this.OnmatkhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diachi", DbType="NVarChar(100)")]
		public string diachi
		{
			get
			{
				return this._diachi;
			}
			set
			{
				if ((this._diachi != value))
				{
					this.OndiachiChanging(value);
					this.SendPropertyChanging();
					this._diachi = value;
					this.SendPropertyChanged("diachi");
					this.OndiachiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dienthoai", DbType="VarChar(15)")]
		public string dienthoai
		{
			get
			{
				return this._dienthoai;
			}
			set
			{
				if ((this._dienthoai != value))
				{
					this.OndienthoaiChanging(value);
					this.SendPropertyChanging();
					this._dienthoai = value;
					this.SendPropertyChanged("dienthoai");
					this.OndienthoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaysinh", DbType="Date")]
		public System.Nullable<System.DateTime> ngaysinh
		{
			get
			{
				return this._ngaysinh;
			}
			set
			{
				if ((this._ngaysinh != value))
				{
					this.OnngaysinhChanging(value);
					this.SendPropertyChanging();
					this._ngaysinh = value;
					this.SendPropertyChanged("ngaysinh");
					this.OnngaysinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_DonHang", Storage="_DonHangs", ThisKey="makh", OtherKey="makh")]
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
			entity.KhachHang = this;
		}
		
		private void detach_DonHangs(DonHang entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Loai")]
	public partial class Loai : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _maloai;
		
		private string _tenloai;
		
		private EntitySet<Rubik> _Rubiks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaloaiChanging(int value);
    partial void OnmaloaiChanged();
    partial void OntenloaiChanging(string value);
    partial void OntenloaiChanged();
    #endregion
		
		public Loai()
		{
			this._Rubiks = new EntitySet<Rubik>(new Action<Rubik>(this.attach_Rubiks), new Action<Rubik>(this.detach_Rubiks));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maloai", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int maloai
		{
			get
			{
				return this._maloai;
			}
			set
			{
				if ((this._maloai != value))
				{
					this.OnmaloaiChanging(value);
					this.SendPropertyChanging();
					this._maloai = value;
					this.SendPropertyChanged("maloai");
					this.OnmaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenloai", DbType="NVarChar(30)")]
		public string tenloai
		{
			get
			{
				return this._tenloai;
			}
			set
			{
				if ((this._tenloai != value))
				{
					this.OntenloaiChanging(value);
					this.SendPropertyChanging();
					this._tenloai = value;
					this.SendPropertyChanged("tenloai");
					this.OntenloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Loai_Rubik", Storage="_Rubiks", ThisKey="maloai", OtherKey="maloai")]
		public EntitySet<Rubik> Rubiks
		{
			get
			{
				return this._Rubiks;
			}
			set
			{
				this._Rubiks.Assign(value);
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
		
		private void attach_Rubiks(Rubik entity)
		{
			this.SendPropertyChanging();
			entity.Loai = this;
		}
		
		private void detach_Rubiks(Rubik entity)
		{
			this.SendPropertyChanging();
			entity.Loai = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rubik")]
	public partial class Rubik : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _maloai;
		
		private string _ten;
		
		private string _mota;
		
		private string _hang;
		
		private System.Nullable<decimal> _gia;
		
		private string _hinh;
		
		private System.Nullable<int> _soluongton;
		
		private System.Nullable<System.DateTime> _ngaycapnhat;
		
		private EntitySet<ChiTietDonHang> _ChiTietDonHangs;
		
		private EntityRef<Loai> _Loai;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnmaloaiChanging(System.Nullable<int> value);
    partial void OnmaloaiChanged();
    partial void OntenChanging(string value);
    partial void OntenChanged();
    partial void OnmotaChanging(string value);
    partial void OnmotaChanged();
    partial void OnhangChanging(string value);
    partial void OnhangChanged();
    partial void OngiaChanging(System.Nullable<decimal> value);
    partial void OngiaChanged();
    partial void OnhinhChanging(string value);
    partial void OnhinhChanged();
    partial void OnsoluongtonChanging(System.Nullable<int> value);
    partial void OnsoluongtonChanged();
    partial void OnngaycapnhatChanging(System.Nullable<System.DateTime> value);
    partial void OnngaycapnhatChanged();
    #endregion
		
		public Rubik()
		{
			this._ChiTietDonHangs = new EntitySet<ChiTietDonHang>(new Action<ChiTietDonHang>(this.attach_ChiTietDonHangs), new Action<ChiTietDonHang>(this.detach_ChiTietDonHangs));
			this._Loai = default(EntityRef<Loai>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maloai", DbType="Int")]
		public System.Nullable<int> maloai
		{
			get
			{
				return this._maloai;
			}
			set
			{
				if ((this._maloai != value))
				{
					if (this._Loai.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaloaiChanging(value);
					this.SendPropertyChanging();
					this._maloai = value;
					this.SendPropertyChanged("maloai");
					this.OnmaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ten", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mota", DbType="NVarChar(MAX)")]
		public string mota
		{
			get
			{
				return this._mota;
			}
			set
			{
				if ((this._mota != value))
				{
					this.OnmotaChanging(value);
					this.SendPropertyChanging();
					this._mota = value;
					this.SendPropertyChanged("mota");
					this.OnmotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hang", DbType="NVarChar(50)")]
		public string hang
		{
			get
			{
				return this._hang;
			}
			set
			{
				if ((this._hang != value))
				{
					this.OnhangChanging(value);
					this.SendPropertyChanging();
					this._hang = value;
					this.SendPropertyChanged("hang");
					this.OnhangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> gia
		{
			get
			{
				return this._gia;
			}
			set
			{
				if ((this._gia != value))
				{
					this.OngiaChanging(value);
					this.SendPropertyChanging();
					this._gia = value;
					this.SendPropertyChanged("gia");
					this.OngiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinh", DbType="VarChar(50)")]
		public string hinh
		{
			get
			{
				return this._hinh;
			}
			set
			{
				if ((this._hinh != value))
				{
					this.OnhinhChanging(value);
					this.SendPropertyChanging();
					this._hinh = value;
					this.SendPropertyChanged("hinh");
					this.OnhinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soluongton", DbType="Int")]
		public System.Nullable<int> soluongton
		{
			get
			{
				return this._soluongton;
			}
			set
			{
				if ((this._soluongton != value))
				{
					this.OnsoluongtonChanging(value);
					this.SendPropertyChanging();
					this._soluongton = value;
					this.SendPropertyChanged("soluongton");
					this.OnsoluongtonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaycapnhat", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> ngaycapnhat
		{
			get
			{
				return this._ngaycapnhat;
			}
			set
			{
				if ((this._ngaycapnhat != value))
				{
					this.OnngaycapnhatChanging(value);
					this.SendPropertyChanging();
					this._ngaycapnhat = value;
					this.SendPropertyChanged("ngaycapnhat");
					this.OnngaycapnhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rubik_ChiTietDonHang", Storage="_ChiTietDonHangs", ThisKey="id", OtherKey="id")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Loai_Rubik", Storage="_Loai", ThisKey="maloai", OtherKey="maloai", IsForeignKey=true)]
		public Loai Loai
		{
			get
			{
				return this._Loai.Entity;
			}
			set
			{
				Loai previousValue = this._Loai.Entity;
				if (((previousValue != value) 
							|| (this._Loai.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Loai.Entity = null;
						previousValue.Rubiks.Remove(this);
					}
					this._Loai.Entity = value;
					if ((value != null))
					{
						value.Rubiks.Add(this);
						this._maloai = value.maloai;
					}
					else
					{
						this._maloai = default(Nullable<int>);
					}
					this.SendPropertyChanged("Loai");
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
			entity.Rubik = this;
		}
		
		private void detach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.Rubik = null;
		}
	}
}
#pragma warning restore 1591
