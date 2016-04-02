﻿using System.Web;
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

            bundles.Add(
                new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"));

            bundles.Add(
                new ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"));

            bundles.Add(
                new ScriptBundle("~/bundles/jquerycloudinary").Include(
                    "~/Scripts/jquery.cloudinary*",
                    "~/Scripts/application/ed.cloudinary.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(
                new ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"));

            /* Initialise javascript ed window variable namespace */
            bundles.Add(
                new Bundle("~/scripts/ed-init", new JsMinify())
                    .Include("~/Scripts/application/ed.object-init.js"));

            bundles.Add(
                new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/respond.js"));

            bundles.Add(
                new ScriptBundle("~/bundles/themes").Include(
                    "~/Scripts/Theme/*.js"));

            bundles.Add(
                new StyleBundle("~/Content/themes").Include(
                    "~/Content/Theme/css/*.css"));

            bundles.Add(
                new StyleBundle("~/Content/css").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/site.css"));

            bundles.Add(
                new LessBundle("~/Content/styles").Include(
                    "~/Content/style.less"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = !HttpContext.Current.IsDebuggingEnabled;
        }
    }
}
