using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
namespace eGonullu.Filters
{
	public class LoginCheck : ActionFilterAttribute
	{

		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			if (filterContext.HttpContext.Session.GetString("userId") != null)
			{
				base.OnActionExecuting(filterContext);
			}
			else
			{
				filterContext.HttpContext.Response.Redirect("/login");
			}
		}
	}
}
