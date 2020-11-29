using System.Web;
using System.Web.Optimization;

namespace Ambit_Verd
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css/layout").Include("~/Content/css/Layout.css"));
            bundles.Add(new StyleBundle("~/Content/css/index").Include("~/Content/css/index.min.css"));
            bundles.Add(new StyleBundle("~/Content/css/services").Include("~/Content/css/Services.min.css"));
        }
    }
}
