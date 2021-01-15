using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace eGonullu.Filters
{

	public class LoginCheck : ActionFilterAttribute, IActionFilter
	{
		private readonly IHttpContextAccessor _httpContextAccessor;
		private ISession _session => _httpContextAccessor.HttpContext?.Session;

		public LoginCheck(IHttpContextAccessor httpContextAccessor)
		{
			_httpContextAccessor = httpContextAccessor;
		}

		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			if (_session.GetString("userId").ToString() == "")
			{
				base.OnActionExecuting(filterContext);
			}
			else
				_httpContextAccessor.HttpContext?.Response.Redirect("/login");
		}
	}
}
