using System.Web;
using System.Web.Optimization;

namespace PortalConhecimento.UI.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/validate.cpf.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-mask").Include(
                        "~/Scripts/jquery.mask.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-cookies.js",
                "~/Scripts/angular-route.js",
                "~/Scripts/angular-animate.js"));

            bundles.Add(new ScriptBundle("~/bundles/ng-tags-input").Include("~/Scripts/ng-tags-input.js"));

            bundles.Add(new ScriptBundle("~/bundles/apps/anuncio-app").Include(
                "~/Scripts/apps/anuncios/anuncio-app.js",
                "~/Scripts/apps/anuncios/controllers/anuncio-controller.js",
                "~/Scripts/apps/anuncios/controllers/cadastro-inicial-controller.js",
                "~/Scripts/apps/anuncios/controllers/cadastro-proximo-controller.js",
                "~/Scripts/apps/anuncios/controllers/cadastro-final-controller.js",
                "~/Scripts/apps/anuncios/services/estado-service.js",
                "~/Scripts/apps/anuncios/services/cidade-service.js",
                "~/Scripts/apps/anuncios/services/bairro-service.js",
                "~/Scripts/apps/anuncios/services/anuncio-service.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/toastr").Include(
                "~/Scripts/toastr.js",
                "~/Scripts/toastr-defaults.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-select").Include(
                "~/Scripts/bootstrap-select.js",
                "~/Scripts/i18n/defaults-pt_BR.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular-bootstrap-select").Include("~/Scripts/angular-bootstrap-select.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular-rangeslider").Include("~/Scripts/angular.rangeSlider.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/font-awesome.css",
                "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/ng-tags-input").Include(
                "~/Content/ng-tags-input.css",
                "~/Content/ng-tags-input.bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap-select").Include("~/Content/bootstrap-select.css"));

            bundles.Add(new StyleBundle("~/Content/angular-rangeslider").Include("~/Content/angular.rangeSlider.css"));

            bundles.Add(new StyleBundle("~/Content/toastr").Include("~/Content/toastr.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
