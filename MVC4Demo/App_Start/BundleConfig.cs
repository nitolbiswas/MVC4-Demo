using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVC4Demo.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Bundles/js").Include
                ("~/Scripts/bootstrap.js", "~/Scripts/jquery-1.10.2"));

            bundles.Add(new StyleBundle("~/Bundles/css").Include
                ("~/Content/bootstrap.css", "~/Content/Site.css"));

            #if DEBUG

                        BundleTable.EnableOptimizations = false;
            #else
                    BundleTable.EnableOptimizations = true;
            #endif
        }
    }
}