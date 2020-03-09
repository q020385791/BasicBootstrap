using System.Web;
using System.Web.Optimization;

namespace testMVC
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862

        //很多個js和css檔案一次打包在Layout載入

        //Layout載入方式
        //@Styles.Render("~/Content/css")
        //@Styles.Render("~/Content/js")
        public static void RegisterBundles(BundleCollection bundles)
        {
            //註冊虛擬打包路徑， 所有相關檔案加入
            bundles.Add(new ScriptBundle("~/Content/css").Include(
                        "~/Content/bootstrap.min.css"
                        ));
            bundles.Add(new ScriptBundle("~/Content/js").Include(
                        "~/Scripts/popper.min.js",
                        "~/Scripts/jquery-3.4.1.min.js",
                        //"~/Scripts/bootstrap.bundle.js"
                        "~/Scripts/bootstrap.min.js"
                        
                        ));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好可進行生產時，請使用 https://modernizr.com 的建置工具，只挑選您需要的測試。
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
        }
    }
}
