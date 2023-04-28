using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using ShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WEBPHONE.Areas.Admin.Controllers
{
    public class BaoCaoController : Controller
    {
        // GET: Admin/BaoCao
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult Report(string lang)
        {
            var db = new ShopConnectionDB();

            if (string.IsNullOrEmpty(lang))
            {
                lang = DateTime.Now.Year.ToString();

            }
            int langInt = int.Parse(lang);

            var data = db.Fetch<dynamic>(@"SELECT MONTH(NgayTao) AS Thang, SUM(TongTien) AS TongThang
                                FROM HoaDon
                                WHERE YEAR(NgayTao) = @langInt
                                GROUP BY MONTH(NgayTao)
                                ORDER BY MONTH(NgayTao) ASC",
                                new { langInt});
            var data2 = db.Fetch<dynamic>("SELECT YEAR(NgayTao) AS Nam, SUM(TongTien) AS TongNam FROM HoaDon GROUP BY YEAR(NgayTao) ORDER BY YEAR(NgayTao) ASC");

            
            //Tháng
            var chartData = new
            {               
                labels = data.Select(x => x.Thang).ToArray(),
               
                datasets = new[]
                {
                    new
                    {
                        label = "Tổng tiền của tháng",
                        data = data.Select(x => x.TongThang).ToArray(),
                        backgroundColor = new [] { "#3e95cd" },
                        hoverBackgroundColor = new[] { "#2e59d9" },
                    }
                }
            };

            //Năm
            var chartData2 = new
            {
                labels = data2.Select(x => x.Nam).ToArray(),

                datasets = new[]
                {
                    new
                    {
                        
                        data = data2.Select(x => x.TongNam).ToArray(),
                        backgroundColor = new [] { "#4e73df", "#36b9cc" },
                        
                        hoverBackgroundColor = new[] { "#2e59d9", "#2c9faf", "#17a673" },
                        hoverBorderColor= new [] { "rgba(234, 236, 244, 1)" },

                    }
                }
            };

            //var data3 = db.Fetch<dynamic>("SELECT SUM(TongTien) AS TotalMoney FROM HoaDon WHERE MONTH(NgayTao) = MONTH(GETDATE()) AND YEAR(NgayTao) = YEAR(GETDATE())");

            ViewBag.ChartData = JsonConvert.SerializeObject(chartData);
            ViewBag.ChartData2 = JsonConvert.SerializeObject(chartData2);
      
            return View();
        }

    }
}