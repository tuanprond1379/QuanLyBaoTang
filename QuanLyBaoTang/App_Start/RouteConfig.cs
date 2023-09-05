using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace QuanLyBaoTang
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.MapRoute(
             name: "",
             url: "Dang-Nhap",
             defaults: new { controller = "DangNhap", action = "DangNhap", id = UrlParameter.Optional }
         );
            routes.MapRoute(
           name: "",
           url: "BT-KetNoi-CSDL",
           defaults: new { controller = "BTKetNoiCSDL", action = "BTKetNoiCSDL", id = UrlParameter.Optional }
        );
            routes.MapRoute(
            name: "",
            url: "Them-Moi-Sua-Xoa",
            defaults: new { controller = "ThemMoiSuaXoa", action = "ThemMoiSuaXoa", id = UrlParameter.Optional }
        );
            routes.MapRoute(
            name: "",
            url: "KN-CSDL",
            defaults: new { controller = "KNCSDL", action = "KNCSDL", id = UrlParameter.Optional }
        );
            routes.MapRoute(
            name: "",
            url: "Mon-Hoc",
            defaults: new { controller = "MonHoc", action = "MonHoc", id = UrlParameter.Optional }
        );
            routes.MapRoute(
            name: "",
            url: "Hoc-Ajax",
            defaults: new { controller = "HocAjax", action = "HocAjax", id = UrlParameter.Optional }
        );
            routes.MapRoute(
            name: "",
            url: "Farm-Work",
            defaults: new { controller = "FarmWork", action = "FarmWork", id = UrlParameter.Optional }
        );
            routes.MapRoute(
             name: "",
             url: "In-Ten-Nhan-Vien",
             defaults: new { controller = "InTenNhanVien", action = "InTenNhanVien", id = UrlParameter.Optional }
         );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
            name: "",
            url: "Bai-Tap",
            defaults: new { controller = "Baitap", action = "Baitap", id = UrlParameter.Optional }
        );
            routes.MapRoute(
             name: "",
             url: "In-Ten-Nhan-Vien",
             defaults: new { controller = "InTenNhanVien", action = "InTenNhanVien", id = UrlParameter.Optional }
         );
            routes.MapRoute(
             name: "",
             url: "OOP-Jquery",
             defaults: new { controller = "OOPJquey", action = "OOPJquey", id = UrlParameter.Optional }
         );
            routes.MapRoute(
              name: "",
              url: "Bai-Tap-Thuc-Hanh",
              defaults: new { controller = "BaitapThucHanh", action = "BaitapThucHanh", id = UrlParameter.Optional }
          );
            routes.MapRoute(
               name: "",
               url: "Danh-Muc-He-Thong",
               defaults: new { controller = "DanhMucHeThong", action = "DanhMucHeThong", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "",
               url: "Hoc-Jquery",
               defaults: new { controller = "HocJquery", action = "HocJquery", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "",
               url: "DashBoard",
               defaults: new { controller = "DashBoard", action = "DashBoard", id = UrlParameter.Optional }
           );
          
            routes.MapRoute(
              name: "",
              url: "QuanLyHienVat",
              defaults: new { controller = "QuanLyHienVat", action = "QuanLyHienVat", id = UrlParameter.Optional }
          );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "QuanLyHienVat", action = "QuanLyHienVat", id = UrlParameter.Optional }
            );
        }
    }
}
