using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBPHONE.Models.BUSS;

namespace WEBPHONE.Controllers
{
    public class DonHangController : Controller
    {
        // GET: DonHang
        public ActionResult Index()
        {
            ViewBag.DonHang = DonHangBUS.LoadHoaDon(User.Identity.GetUserId());
            return View();
        }
    }
}