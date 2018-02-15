using System.Web;
using System.Web.Optimization;

namespace MyMVCApplication

{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;
           // BundleTable.Bundles.UseCdn = true;
            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
               "~/Scripts/kendo/kendo.all.min.js",
                "~/Scripts/kendo/kendo.grid.min.js",
                "~/Scripts/kendo/kendo.aspnetmvc.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery/jquery.js"));
            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
                "~/Content/kendo/kendo.common.min.css",
                "~/Content/kendo/kendo.material.mobile.min.css",
               "~/Content/kendo/kendo.material.min.css"));
            bundles.Add(new StyleBundle("~/Content/Bootstrap/css").Include(
                "~/Content/Bootstrap/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/Content/App/css").Include(
               "~/Content/MyMVCApplication/app.css"));
            bundles.IgnoreList.Clear();
        }
    }
}
