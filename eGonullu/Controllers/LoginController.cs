using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eGonullu.Controllers
{
	[Authorize]
	public class LoginController : Controller
	{
		// GET: Login
		public IActionResult Index()
		{
			return RedirectToAction("Index", "Home");
		}
	}
}