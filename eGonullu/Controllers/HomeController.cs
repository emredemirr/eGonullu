using eGonullu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using eGonullu.Services;
using eGonullu.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace eGonullu.Controllers
{
	[Authorize]
	public class HomeController : Controller
	{
		private IActivityData _activityData;
		private IUserData _userData;

		public HomeController(IActivityData activityData, IUserData userData)
		{
			_activityData = activityData;
			_userData = userData;
		}
		[AllowAnonymous]
		public IActionResult Index()
		{
			
			if (!User.Identity.IsAuthenticated)
			{
				return View("Unauthorized");
			}
			else
			{
				addIfNewUser();
				var viewModel = new HomeIndexViewModel
				{
					Activities = _activityData.GetAll()
				};
				return View(viewModel);
			}
		}
		[Route("[controller]/[action]/{city}/{state}")]
		public IActionResult Index(string city, string state)
		{
			ViewBag.City = city;
			ViewBag.State = state;
			var viewModel = new HomeIndexViewModel
			{
				Activities = _activityData.GetByCityAndState(city, state)
			};
			return View(viewModel);
		}
		[Route("[controller]/[action]/{city}")]
		public IActionResult Index(string city)
		{
			var viewModel = new HomeIndexViewModel
			{
				Activities = _activityData.GetByCity(city)
			};
			return View(viewModel);
		}
		public IActionResult Test()
		{
			IEnumerable<Claim> claims = User.Claims;
			return View(claims);
		}
		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
		
		private bool checkIfUserExist()
		{
			return _userData.GetAll().Any(u =>
				u.Id == User.Claims.SingleOrDefault(c => 
					c.Type.EndsWith("nameidentifier")).Value);
		}

		private void addIfNewUser()
		{
			if (!checkIfUserExist())
			{
				var user = new User
				{
					Email = User.Claims.SingleOrDefault(c =>
						c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name").Value,
					Name = User.Claims.SingleOrDefault(c =>
						c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname").Value,
					LastName = User.Claims.SingleOrDefault(c =>
						c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname").Value,
					Id = User.Claims.SingleOrDefault(c =>
						c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value,
					Phone = "",
					Tc = ""
				};
				_userData.Add(user);
			}
		}
	}
}
