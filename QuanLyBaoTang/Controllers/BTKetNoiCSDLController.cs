using QuanLyBaoTang.ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace QuanLyBaoTang.Controllers
{
    public class BTKetNoiCSDLController : Controller
    {
        // GET: BTKetNoiCSDL
        public ActionResult BTKetNoiCSDL()
        {
            return View();
        }
        XEntities _en = new XEntities();
        [HttpGet]
        public JsonResult LoadData()
        {
            try
            {
                var lstData = _en.tblPhongBans.AsEnumerable()
                    .Select(a => new
                    {
                        a.IdPhongBan,
                        a.tenPhongBan,
                        a.SoluongNhanvien,
                        ngayTaoPhong = a.ngayTaoPhong != null ? string.Format("{0:dd-MM-yyyy}", a.ngayTaoPhong) : "",
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
        public JsonResult ThemData(string ten_phong, int so_luong_nv, DateTime? ngay_tao ) {
            try
            {
                tblPhongBan _pb = new tblPhongBan();
                _pb.IdPhongBan = 0;
                _pb.tenPhongBan = ten_phong;
                _pb.SoluongNhanvien = so_luong_nv;
                _pb.ngayTaoPhong = ngay_tao;
                _en.tblPhongBans.Add(_pb);
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
        [HttpGet]
        public JsonResult LoadDetal(Int64 idPhongBan)
        {
            try
            {
                var data = _en.tblPhongBans.Where(a => a.IdPhongBan == idPhongBan).AsEnumerable().Select(a => new
                {
                    a.IdPhongBan,
                    a.tenPhongBan,
                    a.SoluongNhanvien,
                    ngayTaoPhong = a.ngayTaoPhong != null ? string.Format("{0:yyyy-MM-dd}", a.ngayTaoPhong) : "",



                }).FirstOrDefault();
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
        public JsonResult deleteData(Int64 idPhongBan)
        {
            try
            {
                var data = _en.tblPhongBans.Where(c => c.IdPhongBan == idPhongBan).FirstOrDefault();
                if (data != null)
                {
                    _en.tblPhongBans.Remove(data);
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
