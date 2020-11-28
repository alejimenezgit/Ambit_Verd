using System.Web;
using System.Web.Optimization;

namespace Ambit_Verd
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css/layout").Include("~/Content/css/Layout.css"));

        }
    }
}
