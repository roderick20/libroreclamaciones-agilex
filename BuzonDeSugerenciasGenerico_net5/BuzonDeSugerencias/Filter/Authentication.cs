using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace BuzonDeSugerencias.Filter
{
	public class Authentication : Attribute, IActionFilter, IFilterMetadata
	{
		public void OnActionExecuting(ActionExecutingContext context)
		{
            //context.HttpContext.Session.SetInt32("UserId", 1);
            //context.HttpContext.Session.SetString("UserName", "Admin");

            PathString path = context.HttpContext.Request.Path;
            List<string> path_anonymus = new List<string>();
            path_anonymus.Add("/Login");
            path_anonymus.Add("/Logout");
            path_anonymus.Add("/");
            path_anonymus.Add("/Home/Index");
            path_anonymus.Add("/Home/Revision");
            path_anonymus.Add("/get-captcha-image");
            string anonymus = path_anonymus.Where((string m) => m.Equals((string)path)).FirstOrDefault();
            if (anonymus == null && string.IsNullOrEmpty(context.HttpContext.Session.GetString("UserId")))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                {
                    controller = "Admin",
                    action = "Login"
                }));
            }
        }

		public void OnActionExecuted(ActionExecutedContext context)
		{
		}
	}
}
