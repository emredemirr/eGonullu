using eGonullu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using eGonullu.Services;
using eGonullu.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace eGonullu.Controllers
{
	public class HomeController : Controller
	{
		private IActivityData _activityData;
		private IUserData _userData;

		public HomeController(IActivityData activityData, IUserData userData)
		{
			_activityData = activityData;
			_userData = userData;
		}
		public IActionResult Index()
		{
			var viewModel = new HomeIndexViewModel
			{
				Activities = _activityData.GetAll()
			};
			return View(viewModel);
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
		
	}
}
