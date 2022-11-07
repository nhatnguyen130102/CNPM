using QLKhachSan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKhachSan.Areas.Admin.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: Admin/HomeAdmin
        public ActionResult Phong()
        {
            phongList phongList = new phongList();
            List<Phong> obj = phongList.GetPhongs(string.Empty).OrderBy(x=>x.maphong).ToList();
            return View(obj);
        }
        public ActionResult LoaiPhong()
        {
            return View();
        }
        public ActionResult DatPhong()
        {
            return View();
        }
        public ActionResult ThemPhong()
        {
            return View();
        }
        public ActionResult Email()
        {
            return View();
        }
        public ActionResult HoaDon()
        {
            return View();
        }
        public ActionResult ThemHoaDon()
        {
            return View();
        }
        public ActionResult NguoiDung()
        {
            return View();
        }
        public ActionResult ThemNguoiDung()
        {
            return View();
        }
        public ActionResult ThemLoaiPhong()
        {
            return View();
        }
        public ActionResult DichVu()
        {
            return View();
        }
        public ActionResult ThemDichVu()
        {
            return View();
        }
    }
}