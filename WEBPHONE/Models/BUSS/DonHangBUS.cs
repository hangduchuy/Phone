using ShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBPHONE.Models.BUSS
{
    public class DonHangBUS
    {
        public static List<HoaDon> LoadHoaDon(string mataikhoan)
        {
            var db = new ShopConnectionDB();
            return db.Query<HoaDon>("select * from HoaDon where NguoiDat= @0", mataikhoan).ToList();

        }
    }
}