using QuanLyBaoTang.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyBaoTang.Controllers
{
    public class ThemMoiSuaXoaController : Controller
    {
        // GET: ThemMoiSuaXoa
        public ActionResult ThemMoiSuaXoa()
        {
            return View();
        }
        XEntities _en = new XEntities();

        [HttpGet]
        public JsonResult LoadTable()
        {
            try
            {
                var lstData = _en.tblNhan_Vien.AsEnumerable()
                    
                    .Select(c => new
                    {

                        c.idNhanVien,
                        c.ho_ten,
                        c.gioi_tinh,
                        ngay_sinh = c.ngay_sinh != null ? string.Format("{0:dd-MM-yyyy}",c.ngay_sinh) : "",
                        c.luong,
                        trang_thai = c.isTrangThai == true ? "đang làm việc" : "đã nghỉ",
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
        public JsonResult SaveData(string ho_ten, string gioi_tinh, DateTime? ngay_sinh, int luong, bool isTrangThai) {
            try
            {
                // Tạo ra đối tượng bảng : và gán dữ liệu cho các trường thông tin
                tblNhan_Vien _nv = new tblNhan_Vien();
                _nv.idNhanVien = 0;
                _nv.ho_ten = ho_ten;
                _nv.gioi_tinh = gioi_tinh;
                _nv.ngay_sinh = ngay_sinh;
                _nv.luong = luong;
                _nv.isTrangThai = isTrangThai;

               // thêm vào dùng Add()
               _en.tblNhan_Vien.Add(_nv);
                // lưu thông tin vào csdl
                _en.SaveChanges();


                return Json(new
                {
                    status = true,
                }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex){
                return Json(new
                {
                    status = false,
                }, JsonRequestBehavior.AllowGet);
            }
        
        }
        [HttpGet]
        public JsonResult LoadDetal(Int64 idNhanVien)
        {
            try
            {
                // đối mới thằng load ra table ==> {0:dd-MM-yyyy}
                // đối mới thằng load detal ==> {0:yyyy-MM-dd} khi mà truyền dữ lieeuh ngày sinh vào ô input phải convot ngược lại nó mới hiểu được
                var data = _en.tblNhan_Vien.Where(c => c.idNhanVien == idNhanVien).AsEnumerable()

                    .Select(c => new
                    {

                        c.idNhanVien,
                        c.ho_ten,
                        c.gioi_tinh,
                        ngay_sinh = c.ngay_sinh != null ? string.Format("{0:yyyy-MM-dd}", c.ngay_sinh) : "",
                        c.luong,
                        c.isTrangThai
                    }).FirstOrDefault(); // lấy ra một bản ghi
                return Json(new
                {
                    data,
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
        public JsonResult deleteData(Int64 idNhanVien)
        {
            try
            {
                // lấy ra bản ghi có id nhan vien = cái idnhanvien truyền vào
                var data = _en.tblNhan_Vien.Where(c => c.idNhanVien == idNhanVien).FirstOrDefault();
                // check bản ghi có tồn tại hay không
                if (data != null)
                {
                    //xóa bản ghi
                    _en.tblNhan_Vien.Remove(data);
                    //lưu lại thay đổi
                    _en.SaveChanges();
                }


                return Json(new
                {
                    
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
