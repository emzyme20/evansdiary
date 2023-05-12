using System.Web;
using System.Web.Optimization;

namespace EvansDiary.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Ignore("*.intellisense.js");
            bundles.IgnoreList.Ignore("*-vsdoc.js");
            bundles.IgnoreList.Ignore("*.debug.js");
            bundles.IgnoreList.Ignore("*.min.js");
            bundles.IgnoreList.Ignore("*.min.css");
            bundles.IgnoreList.Ignore("*.map");

            bundles.UseCdn = true;

            // Style bundles
            bundles.Add(
                new StyleBundle("~/Content/css").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/site.css",
                    "~/Content/Theme/css/*.css"));

            //bundles.Add(
            //    new StyleBundle("~/Content/css/reset").Include(
            //        "~/Content/libs/timeline/reset.css"));

            bundles.Add(
                new StyleBundle("~/Content/css/timeline").Include(
                    "~/Content/libs/timeline/timeline.css"));

            bundles.Add(
                new LessBundle("~/Content/styles").Include(
                    "~/Content/style.less"));

            // Script bundles
            var jquery = new Bundle("~/bundles/jquery", "http://ajax.googleapis.com/ajax/libs/jquery/3.0.0/jquery.min.js")
                .Include("~/Scripts/jquery-{version}.js");

            jquery.CdnFallbackExpression = "window.jQuery";

            bundles.Add(jquery);

            bundles.Add(
                new Bundle("~/bundles/jquerycloudinary").Include(
                    "~/Scripts/cloudinary-jquery*",
                    "~/Scripts/application/ed.cloudinary.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(
                new Bundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"));

            /* Initialise javascript ed window variable namespace */
            bundles.Add(
                new Bundle("~/scripts/ed-init", new JsMinify())
                    .Include("~/Scripts/application/ed.object-init.js"));

            bundles.Add(
                new Bundle("~/bundles/bootstrap").Include(
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/respond.js",
                    "~/Scripts/Theme/*.js",
                    "~/Scripts/jquery.validate*"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = !HttpContext.Current.IsDebuggingEnabled;
        }
    }
}
