using QuanLyBaoTang.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyBaoTang.Controllers
{
    public class KNCSDLController : Controller
    {
        // GET: KNCSDL
        public ActionResult KNCSDL()
        {
            return View();
        }
       
        // khai báo đối tượng truy cập csdl
        XEntities _en = new XEntities();
        [HttpGet]
        public JsonResult LoadData(string txtsearchHoTen) 
        {
            try
            {
                //1. câu lệnh lấy ra bảng => _en.(tên bảng)
                //2. câu lệnh điều kiện where : x là tham chiếu đến bảng => lấy ra giá trị các trường thông tin
                //3. câu lệnh chọn select
                var lstData = _en.tblNhan_Vien
                    .Where(x => txtsearchHoTen != "" ? x.ho_ten.ToLower().Contains(txtsearchHoTen.ToLower()) : true)
                    .Select(c => new 
                {

                        c.idNhanVien,
                        c.ho_ten,
                        c.gioi_tinh,
                        c.ngay_sinh,
                        c.luong,
                        trang_thai = c.isTrangThai == true? "đang làm việc" : "đã nghỉ",
                }).ToList();
                return Json(new
                {
                    lstData,
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
        [HttpPost]
        public JsonResult SaveData(string ho_ten, string gioi_tinh, DateTime? ngay_sinh, int luong, bool isTrangThai)
        {
            try
            { 
                tblNhan_Vien _nv = new tblNhan_Vien();
                _nv.idNhanVien = 0;
                _nv.ho_ten = ho_ten;
                _nv.gioi_tinh = gioi_tinh;
                _nv.ngay_sinh = ngay_sinh;
                _nv.luong = luong;
                _nv.isTrangThai = isTrangThai;
                _en.tblNhan_Vien.Add(_nv); 
                _en.SaveChanges();
                return Json(new
                {
                    status = true,
                }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    status = false,
                }, JsonRequestBehavior.AllowGet);
            }

        }
    }
}
