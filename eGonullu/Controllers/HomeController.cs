using eGonullu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using eGonullu.Services;
using eGonullu.ViewModels;

namespace eGonullu.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IActivityData _activityData;

		public HomeController(IActivityData activityData, ILogger<HomeController> logger)
		{
			_activityData = activityData;
			_logger = logger;
		}

		public IActionResult Index()
		{
			var viewModel = new HomeIndexViewModel
			{
				Activities = _activityData.GetAll()
			};
			return View(viewModel);
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
