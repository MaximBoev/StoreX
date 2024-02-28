using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace StoreX.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
                "~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/nouislider/css").Include(
                "~/Content/nouislider.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/slick/css").Include(
                "~/Content/slick.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/slick-theme/css").Include(
                "~/Content/slick-theme.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/style/css").Include(
                "~/Content/style.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                "~/Scripts/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
                "~/Scripts/jquery.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery/zoom/js").Include(
                "~/Scripts/jquery.zoom.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/main/js").Include(
                "~/Scripts/main.js"));
            bundles.Add(new ScriptBundle("~/bundles/nouislider/js").Include(
                "~/Scripts/nouislider.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/slick/js").Include(
                "~/Scripts/slick.min.js"));

        }
    }
}