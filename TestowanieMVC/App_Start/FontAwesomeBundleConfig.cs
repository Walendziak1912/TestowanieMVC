using System.Web.Optimization;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(TestowanieMVC.App_Start.FontAwesomeBundleConfig), "RegisterBundles")]

namespace TestowanieMVC.App_Start
{
	public class FontAwesomeBundleConfig
	{
		public static void RegisterBundles()
		{
			// Add @Styles.Render("~/Content/fontawesome") in the <head/> of your _Layout.cshtml view
			// When <compilation debug="true" />, MVC will render the full readable version. When set to <compilation debug="false" />, the minified version will be rendered automatically
			BundleTable.Bundles.Add(new StyleBundle("~/Content/fontawesome").Include("~/Content/fontawesome/font-awesome.css"));
			BundleTable.Bundles.Add(new ScriptBundle("~/bundles/knockout").Include("~/Scripts/knockout-3.5.1.js"));
		}
	}
}