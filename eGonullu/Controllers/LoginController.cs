using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eGonullu.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eGonullu.Controllers
{
	public class LoginController : Controller
	{
		private IUserData _userData;

		public LoginController(IUserData userData)
		{
			_userData = userData;
		}
		// GET: Login
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(string email, string password)
		{
			Console.WriteLine("Ok");
			var loginCheck = _userData.Login(email, password).Result;
			if (loginCheck != -1)
			{
				HttpContext.Session.SetInt32("userId", loginCheck);
				return Content("Oldu");
			}
			return Content("Olmadı");
		}
	}
}