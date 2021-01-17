using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eGonullu.Models;
using eGonullu.Services;
using Microsoft.AspNetCore.Http;

namespace eGonullu.Controllers
{
	public class RegisterController : Controller
	{
		private IUserData _userData;

		public RegisterController(IUserData userData)
		{
			_userData = userData;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(string email, string password, string name, string lastName)
		{
			Console.WriteLine("Ok");
			var loginCheck = _userData.Add(new User
			{
				Email = email,
				Name = name,
				LastName = lastName,
				Password = password
			}).Result;
			if (loginCheck != -1)
			{
				HttpContext.Session.SetInt32("userId", loginCheck);
				return RedirectToAction("Index", "Home");
			}

			return View();
		}
	}
}
