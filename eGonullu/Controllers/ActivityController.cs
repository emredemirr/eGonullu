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
    public class ActivityController : Controller
    {
	    private IUserData _userData;
	    private IActivityData _activityData;

	    public ActivityController(IActivityData activityData, IUserData userData)
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

        public IActionResult Details()
        {
	        return View();
        }

        private User getUser()
        {
	        return _userData.GetUserByClaims(User.Claims);
        }
    }
}