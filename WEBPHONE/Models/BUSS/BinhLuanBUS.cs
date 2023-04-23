using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopConnection;
namespace WEBPHONE.Models.BUSS
{
    public class BinhLuanBUS
    {
        public static List<BinhLuan> LoadBinhLuan()
        {
            var db = new ShopConnectionDB();
            return db.Query<BinhLuan>("select * from BinhLuan ORDER BY NgayBL desc").ToList();
        }
        public static void Them(string masanpham, string mataikhoan, string noidung)
        {

            using (var db = new ShopConnectionDB())
            {
                var user = db.SingleOrDefault<AspNetUser>("SELECT * FROM AspNetUsers WHERE Id = @0", mataikhoan);
                string userName = (user != null) ? user.UserName : "Acount";

                BinhLuan binhluan = new BinhLuan()
                {
                    CustomerID=mataikhoan,
                    Name=userName,
                    ProductID=masanpham,
                    Content=noidung,
                    NgayBL = DateTime.Now,

                };
                db.Insert(binhluan);



            }
        }
        public static List<BinhLuan> LoadBinhLuanBySanPhamId(string sanPhamId)
        {
            var db = new ShopConnectionDB();
            return db.Query<BinhLuan>("SELECT * FROM BinhLuan WHERE ProductID = @Id ORDER BY NgayBL DESC", new { Id = sanPhamId }).ToList();
        }

    }
}