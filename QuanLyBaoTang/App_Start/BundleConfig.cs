using System.Web;
using System.Web.Optimization;

namespace QuanLyBaoTang
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new Bundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/diamond/css").Include(
                      "~/Assets/images/favicon.ico",
                      "~/Assets/css/style.css"));
    //        < link rel = "icon" href = "~/Assets/images/favicon.ico" type = "image/x-icon" >

    //< link rel = "stylesheet" href = "~/Assets/css/style.css" >


            bundles.Add(new ScriptBundle("~/diamond/js").Include("~/Assets/js/vendor-all.min.js",
                "~/Assets/js/plugins/bootstrap.min.js",
                "~/Assets/js/ripple.js",
                "~/Assets/js/pcoded.min.js",
                "~/Assets/js/menu-setting.min.js"));
    //         < script src = "~/Assets/js/vendor-all.min.js" ></ script >
    //< script src = "~/Assets/js/plugins/bootstrap.min.js" ></ script >
    //< script src = "~/Assets/js/ripple.js" ></ script >
    //< script src = "~/Assets/js/pcoded.min.js" ></ script >
    //< script src = "~/Assets/js/menu-setting.min.js" ></ script >
     }
    }
}
