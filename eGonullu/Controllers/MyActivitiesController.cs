using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using eGonullu.Filters;
using eGonullu.Models;
using eGonullu.Services;
using eGonullu.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eGonullu.Controllers
{
	[LoginCheck]
	public class MyActivitiesController : Controller
	{
		private IUserData _userData;
		private IActivityData _activityData;

		public MyActivitiesController(IActivityData activityData, IUserData userData)
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
			var participants = new List<User>();
			foreach (var activityParticipant in _activityData.Get(id).Participants)
			{
				participants.Add(_userData.Get(activityParticipant.UserId).Result);
			}
			var viewModel = new ActivityDetailsViewModel
			{
				Activity = _activityData.Get(id),
				ActivityUser = getUser(),
				Participants = participants
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
					UserId = getUser().Id,
					ActivityDate = model.ActivityDate,
					AddressDetail = model.AddressDetail,
					Title = model.Title,
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

		[HttpGet("[controller]/[action]/{id}")]
		public IActionResult Edit(int id)
		{
			return View(_activityData.Get(id));
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(Activity activity)
		{
			if (getUser().Id != activity.UserId)
			{
				return RedirectToAction("Index", "Home");
			}
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
			var userId = HttpContext.Session.GetInt32("userId").GetValueOrDefault();
			return _userData.Get(userId).Result;
		}
	}
}