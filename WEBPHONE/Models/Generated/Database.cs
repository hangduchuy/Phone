
// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `ShopConnection`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=Musk\SQL;Initial Catalog=ShopOnline;Integrated Security=True`
//     Schema:                 ``
//     Include Views:          `False`

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace ShopConnection
{
	public partial class ShopConnectionDB : Database
	{
		public ShopConnectionDB() 
			: base("ShopConnection")
		{
			CommonConstruct();
		}

		public ShopConnectionDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			ShopConnectionDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static ShopConnectionDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new ShopConnectionDB();
        }

		[ThreadStatic] static ShopConnectionDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        
		public class Record<T> where T:new()
		{
			public static ShopConnectionDB repo { get { return ShopConnectionDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }
			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }
			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }
		}
	}
	

    
	[TableName("dbo.__MigrationHistory")]
	[PrimaryKey("MigrationId", AutoIncrement=false)]
	[ExplicitColumns]
    public partial class __MigrationHistory : ShopConnectionDB.Record<__MigrationHistory>  
    {
		[Column] public string MigrationId { get; set; }
		[Column] public string ContextKey { get; set; }
		[Column] public byte[] Model { get; set; }
		[Column] public string ProductVersion { get; set; }
	}
    
	[TableName("dbo.AspNetRoles")]
	[PrimaryKey("Id", AutoIncrement=false)]
	[ExplicitColumns]
    public partial class AspNetRole : ShopConnectionDB.Record<AspNetRole>  
    {
		[Column] public string Id { get; set; }
		[Column] public string Name { get; set; }
	}
    
	[TableName("dbo.AspNetUserClaims")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class AspNetUserClaim : ShopConnectionDB.Record<AspNetUserClaim>  
    {
		[Column] public int Id { get; set; }
		[Column] public string UserId { get; set; }
		[Column] public string ClaimType { get; set; }
		[Column] public string ClaimValue { get; set; }
	}
    
	[TableName("dbo.AspNetUserLogins")]
	[PrimaryKey("LoginProvider", AutoIncrement=false)]
	[ExplicitColumns]
    public partial class AspNetUserLogin : ShopConnectionDB.Record<AspNetUserLogin>  
    {
		[Column] public string LoginProvider { get; set; }
		[Column] public string ProviderKey { get; set; }
		[Column] public string UserId { get; set; }
	}
    
	[TableName("dbo.AspNetUserRoles")]
	[PrimaryKey("UserId", AutoIncrement=false)]
	[ExplicitColumns]
    public partial class AspNetUserRole : ShopConnectionDB.Record<AspNetUserRole>  
    {
		[Column] public string UserId { get; set; }
		[Column] public string RoleId { get; set; }
	}
    
	[TableName("dbo.AspNetUsers")]
	[PrimaryKey("Id", AutoIncrement=false)]
	[ExplicitColumns]
    public partial class AspNetUser : ShopConnectionDB.Record<AspNetUser>  
    {
		[Column] public string Id { get; set; }
		[Column] public string Email { get; set; }
		[Column] public bool EmailConfirmed { get; set; }
		[Column] public string PasswordHash { get; set; }
		[Column] public string SecurityStamp { get; set; }
		[Column] public string PhoneNumber { get; set; }
		[Column] public bool PhoneNumberConfirmed { get; set; }
		[Column] public bool TwoFactorEnabled { get; set; }
		[Column] public DateTime? LockoutEndDateUtc { get; set; }
		[Column] public bool LockoutEnabled { get; set; }
		[Column] public int AccessFailedCount { get; set; }
		[Column] public string UserName { get; set; }
	}
    
	[TableName("dbo.BinhLuan")]
	[PrimaryKey("ID")]
	[ExplicitColumns]
    public partial class BinhLuan : ShopConnectionDB.Record<BinhLuan>  
    {
		[Column] public int ID { get; set; }
		[Column] public string CustomerID { get; set; }
		[Column] public string ProductID { get; set; }
		[Column] public string Content { get; set; }
		[Column] public DateTime? NgayBL { get; set; }
		[Column] public string Name { get; set; }
	}
    
	[TableName("dbo.ChiTietHoaDon")]
	[PrimaryKey("HoaDonID", AutoIncrement=false)]
	[ExplicitColumns]
    public partial class ChiTietHoaDon : ShopConnectionDB.Record<ChiTietHoaDon>  
    {
		[Column] public string MaSP { get; set; }
		[Column] public int HoaDonID { get; set; }
		[Column] public string TenSP { get; set; }
		[Column] public int? SoLuong { get; set; }
		[Column] public int? Gia { get; set; }
		[Column] public int? TongTien { get; set; }
	}
    
	[TableName("dbo.HoaDon")]
	[PrimaryKey("ID")]
	[ExplicitColumns]
    public partial class HoaDon : ShopConnectionDB.Record<HoaDon>  
    {
		[Column] public int ID { get; set; }
		[Column] public DateTime? NgayTao { get; set; }
		[Column] public string NguoiDat { get; set; }
		[Column] public string SDT { get; set; }
		[Column] public int? TongTien { get; set; }
		[Column] public int? TrangThai { get; set; }
		[Column] public string NguoiNhan { get; set; }
	}
    
	[TableName("dbo.LoaiSanPham")]
	[PrimaryKey("MaLoaiSP", AutoIncrement=false)]
	[ExplicitColumns]
    public partial class LoaiSanPham : ShopConnectionDB.Record<LoaiSanPham>  
    {
		[Column] public string MaLoaiSP { get; set; }
		[Column] public string TenLoaiSP { get; set; }
		[Column] public string TinhTrang { get; set; }
	}
    
	[TableName("dbo.NhaSanXuat")]
	[PrimaryKey("MaNSX", AutoIncrement=false)]
	[ExplicitColumns]
    public partial class NhaSanXuat : ShopConnectionDB.Record<NhaSanXuat>  
    {
		[Column] public string MaNSX { get; set; }
		[Column] public string TenNSX { get; set; }
		[Column] public string TinhTrang { get; set; }
	}
    
	[TableName("dbo.SanPham")]
	[PrimaryKey("MaSP", AutoIncrement=false)]
	[ExplicitColumns]
    public partial class SanPham : ShopConnectionDB.Record<SanPham>  
    {
		[Column] public string MaSP { get; set; }
		[Column] public string TenSp { get; set; }
		[Column] public string MaLoaiSP { get; set; }
		[Column] public string MaNSX { get; set; }
		[Column] public string CauHinh { get; set; }
		[Column] public string HinhChinh { get; set; }
		[Column] public int? SoLuongDaBan { get; set; }
		[Column] public int? LuotXem { get; set; }
		[Column] public int? Gia { get; set; }
		[Column] public int? TinhTrang { get; set; }
		[Column] public string GhiChu { get; set; }
	}
}
