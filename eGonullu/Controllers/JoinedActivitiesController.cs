using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eGonullu.Models;
using eGonullu.Services;
using eGonullu.ViewModels;
using Microsoft.AspNetCore.Http;

namespace eGonullu.Controllers
{
	public class JoinedActivitiesController : Controller
	{
		private IUserData _userData;
		private IActivityData _activityData;
		private IParticipantData _participantData;

		public JoinedActivitiesController(IActivityData activityData, IUserData userData, IParticipantData participantData)
		{
			_activityData = activityData;
			_userData = userData;
			_participantData = participantData;
		}

		public IActionResult Index()
		{
			var viewModel = new ActivityIndexViewModel
			{
				Activities = _activityData.GetJoinedActivities(getUser().Id)
			};
			return View(viewModel);
		}

		private User getUser()
		{
			return _userData.Get(int.Parse(HttpContext.Session.GetString("userId"))).Result;
		}
	}
}
