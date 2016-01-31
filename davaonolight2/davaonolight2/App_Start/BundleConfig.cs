using System.Web;
using System.Web.Optimization;

namespace davaonolight2
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            string jqueryCdnPath = "https://code.jquery.com/jquery-2.1.3.min.js";
            string angularCdnPath = "https://ajax.googleapis.com/ajax/libs/angularjs/1.3.15/angular.min.js";
            string uiRouterCdnPath = "https://cdnjs.cloudflare.com/ajax/libs/angular-ui-router/0.2.11/angular-ui-router.min.js";
            string bootstrapCdnPath = "https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js";
            string uiBootstrapCdnPath = "https://cdnjs.cloudflare.com/ajax/libs/angular-ui-bootstrap/0.11.0/ui-bootstrap-tpls.min.js";

            bundles.UseCdn = true;

            bundles.Add(new ScriptBundle("~/bundles/jquery",
                jqueryCdnPath).Include("~/app/scripts/jquery/jquery-2.1.3.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs",
                angularCdnPath).Include("~/app/scripts/angular/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/uiRouter",
                uiRouterCdnPath).Include("~/app/scripts/angular/angular-ui-router.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap",
                bootstrapCdnPath).Include("~/app/scripts/bootstrap/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/uibootstrap",
                uiBootstrapCdnPath).Include("~/app/scripts/bootstrap/ui-bootstrap-tpls-0.11.0.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/app/scripts/app.js",
                "~/app/scripts/home.js"));

            string bootstrapCssCdnPath = "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css";


            bundles.Add(new StyleBundle("~/Content/bootstrap",
                bootstrapCssCdnPath).Include("~/app/sandstone.bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/Content/footer").Include("~/app/sticky-footer.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
