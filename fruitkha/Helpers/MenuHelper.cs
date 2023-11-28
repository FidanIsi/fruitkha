using Microsoft.AspNetCore.Mvc.Rendering;

namespace fruitkha.Helpers
{
    public static class MenuHelper
    {
		public static string IsMenuItemActive(this IHtmlHelper htmlHelper, string controller, params string[] actions)
		{
			string currentController = (string)htmlHelper.ViewContext.RouteData.Values["Controller"];
			string currentAction = (string)htmlHelper.ViewContext.RouteData.Values["Action"];

			if (currentController == controller && actions.Contains(currentAction))
			{
				return "current-list-item";
			}

			return "";
		}
	}
}
