using QuanLyBaoTang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace QuanLyBaoTang.Controllers
{
    public class HocAjaxController : Controller
    {
        // GET: HocAjax
        public ActionResult HocAjax()
        {
            return View();
        }
        // để giao thức truyền vào
        [HttpGet]
        // hàm Json
        public JsonResult loadData()
        {
            try
            {
                List<MonHoc> lstHocSinh = new List<MonHoc>()
                {
                    new MonHoc(1,"Pham Tuan Anh", 12, "8D"),
                    new MonHoc(2,"Pham Tuan Anh", 12, "8D"),
                    new MonHoc(3,"Pham Tuan Anh", 12, "8D"),
                    new MonHoc(4,"Pham Tuan Anh", 12, "8D"),
                    new MonHoc(4,"Pham Tuan Anh", 12, "8D"),
                };
                return Json(new
                {
                   lstHocSinh,
                    status = true,
                }, JsonRequestBehavior.AllowGet);
            }
            // Exception sử lý csdl đầu vào và đầu ra
            catch (Exception ex)
            {
                return Json(new
                {
                    Message = ex.Message, // quăng ra lỗi
                    status = false,
                }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}