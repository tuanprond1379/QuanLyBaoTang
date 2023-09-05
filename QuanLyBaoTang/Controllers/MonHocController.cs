using QuanLyBaoTang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyBaoTang.Controllers
{
    public class MonHocController : Controller
    {
        // GET: MonHoc
        public ActionResult MonHoc()
        {
            return View();
        }
        [HttpGet]
        public JsonResult LoadData()
        {
            try
            {
                List<MonHoc1> lstMonHoc = new List<MonHoc1>()
                {
                    new MonHoc1(1,"C# Nâng Cao", "4"),
                    new MonHoc1(2,"C++", "2"),
                    new MonHoc1(3,"Pyphon", "2"),
                    new MonHoc1(4,"Java", "4"),
                    new MonHoc1(4,"JavaScript", "4"),
                };
                return Json(new
                {
                    lstMonHoc,
                    status = true,
                }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Message = ex.Message, 
                    status = false,
                }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}