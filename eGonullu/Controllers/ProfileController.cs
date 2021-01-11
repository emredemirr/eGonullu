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
    public class ProfileController : Controller
    {
	    private IUserData _userData;
		public ProfileController(IUserData userData)
		{
			_userData = userData;
		}
        public IActionResult Index()
        {
	        var model = getUser();
	        return View(model);
        }

        [HttpGet]
        public IActionResult Edit()
		{
			var model = getUser();
			return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
		public IActionResult Edit(User user)
        {

	        if (ModelState.IsValid)
	        {
				_userData.Update(user);
				return RedirectToAction(nameof(Index));
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