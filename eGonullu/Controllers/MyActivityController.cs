using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eGonullu.Models;
using eGonullu.Services;
using eGonullu.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace eGonullu.Controllers
{
	public class MyActivityController : Controller
	{
		private IUserData _userData;
		private IActivityData _activityData;

		public MyActivityController(IActivityData activityData, IUserData userData)
		{
			_activityData = activityData;
			_userData = userData;
		}
		public IActionResult Index()
		{
			var viewModel = new ActivityIndexViewModel
			{
				Activities = _activityData.GetUserActivities(getUser().Id)
			};
			return View(viewModel);
		}

		public IActionResult Details(int id)
		{
			var viewModel = new ActivityDetailsViewModel
			{
				Activity = _activityData.Get(id)
			};
			return View(viewModel);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(ActivityEditViewModel model)
		{
			if (ModelState.IsValid)
			{
				var activity = new Activity
				{
					User = getUser(),
					ActivityDate = model.ActivityDate,
					City = model.City,
					State = model.State,
					Name = model.Name,
					Definition = model.Definition,
					PictureUrl = model.PictureUrl
				};
				activity = _activityData.Add(activity);
				return RedirectToAction(nameof(Details), new { id = activity.Id });
			}
			else
			{
				return View();
			}
		}

		[HttpGet]
		public IActionResult Edit(int id)
		{
			return View(_activityData.Get(id));
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(Activity activity)
		{
			if (ModelState.IsValid)
			{
				_activityData.Update(activity);
				return RedirectToAction(nameof(Details), new { id = activity.Id });
			}
			else
			{
				return View();
			}
		}

		private User getUser()
		{
			return _userData.GetUserByClaims(User.Claims);
		}
	}
}