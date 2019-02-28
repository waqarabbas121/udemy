using System.Web;
using System.Web.Optimization;

namespace Udemy
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/ClientScripts").Include(
                       "~/Areas/Client/js/vendor/modernizr-3.6.0.min.js",
                       "~/Areas/Client/js/vendor/jquery-3.3.1.min.js",
                       "~/Areas/Client/js/popper.min.js",
                       "~/Areas/Client/js/bootstrap.min.js",
                       "~/Areas/Client/js/main.js",
                       "~/Areas/Client/js/owl.carousel.min.js",
                       "~/Areas/Client/js/jquery.flexslider.js",
                       "~/Areas/Client/js/stellarnav.js"
                       ));

            bundles.Add(new StyleBundle("~/ClientStyles").Include(
                      "~/Areas/Client/css/bootstrap.min.css",
                      "~/Areas/Client/css/all.css",
                      "~/Areas/Client/css/stellarnav.css",
                      "~/Areas/Client/css/owl.carousel.min.css",
                      "~/Areas/Client/css/flexslider.css",
                      "~/Areas/Client/css/normalize.css",
                      "~/Areas/Client/css/mobile.css",
                      "~/Areas/Client/css/fonts.css",
                      "~/Areas/Client/css/style.css"
                      ));


            bundles.Add(new ScriptBundle("~/AdminScripts").Include(
                       "~/Areas/Admin/plugins/jQuery/jQuery-2.1.4.min.js",
                       "~/Areas/Admin/plugins/custom/jquery-ui.min.js",
                       "~/Areas/Admin/bootstrap/js/bootstrap.min.js",
                       "~/Areas/Admin/plugins/morris/morris.min.js",
                       "~/Areas/Admin/plugins/sparkline/jquery.sparkline.min.js",
                       "~/Areas/Admin/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                       "~/Areas/Admin/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                       "~/Areas/Admin/plugins/knob/jquery.knob.js",
                       "~/Areas/Admin/plugins/daterangepicker/daterangepicker.js",
                       "~/Areas/Admin/plugins/datepicker/bootstrap-datepicker.js",
                       "~/Areas/Admin/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                       "~/Areas/Admin/plugins/slimScroll/jquery.slimscroll.min.js",
                       "~/Areas/Admin/plugins/fastclick/fastclick.min.js",
                       "~/Areas/Admin/dist/js/app.min.js",
                       "~/Areas/Admin/dist/js/pages/dashboard.js",
                       "~/Areas/Admin/dist/js/demo.js"
                       ));

            bundles.Add(new StyleBundle("~/AdminStyles").Include(
                      "~/Areas/Admin/bootstrap/css/bootstrap.min.css",
                      "~/Areas/Admin/dist/css/AdminLTE.min.css",
                      "~/Areas/Admin/dist/css/skins/_all-skins.min.css",
                      "~/Areas/Admin/plugins/iCheck/flat/blue.css",
                      "~/Areas/Admin/plugins/morris/morris.css",
                      "~/Areas/Admin/plugins/jvectormap/jquery-jvectormap-1.2.2.css",
                      "~/Areas/Admin/plugins/datepicker/datepicker3.css",
                      "~/Areas/Admin/plugins/daterangepicker/daterangepicker-bs3.css",
                      "~/Areas/Admin/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"
                      ));

           
        }
    }
}
