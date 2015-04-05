using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MartyJohnBonales.Web
{
    public class BundlesConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;
            bundles.UseCdn = true;

            var jqueryCdn = "//ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js";
            bundles.Add(new ScriptBundle("~/bundles/jqueryjs", jqueryCdn)
                .Include("~/Scripts/jquery-{version}.js"));

            var bootstrapCdn = "//netdna.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js";
            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs", bootstrapCdn)
                .Include("~/Scripts/bootstrap.js"));

            var globalJsBundle = new ScriptBundle("~/bundles/globaljs")
                .Include("~/Scripts/navbar.js");
            bundles.Add(globalJsBundle);

            var bootstrapCssCnd = "//netdna.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css";
            var boostrapCssBundle = new StyleBundle("~/bundles/bootstrapcss", bootstrapCssCnd)
                .Include("~/Content/bootstrap.css");
            bundles.Add(boostrapCssBundle);

            var globalCssBundle = new StyleBundle("~/bundles/globalcss")
                .Include("~/Content/global.css");
            bundles.Add(globalCssBundle);
        }
    }
}