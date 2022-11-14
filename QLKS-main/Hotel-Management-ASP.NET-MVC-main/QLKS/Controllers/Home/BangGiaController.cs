using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKS.Controllers
{
    public class BangGiaController : Controller
    {
        // GET: BangGia
        QLKS.Models.dataQLKSEntities db = new Models.dataQLKSEntities();
        public ActionResult Index() // not available
        {
            return View();
        }
        public ActionResult GiaPhong() // return GiaPhong.cshtml
        {
            return View(db.tblLoaiPhongs.ToList());
        }
        public ActionResult GiaDichVu() // return GiaDichVu.cshtml
        {
            return View(db.tblDichVus.ToList());
        }
    }
}