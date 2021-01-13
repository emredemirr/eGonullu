using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eGonullu.Models;
using eGonullu.Services;
using eGonullu.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eGonullu.Controllers
{
	[Authorize]
    public class ActivitiesController : Controller
    {
	    private IUserData _userData;
	    private IActivityData _activityData;
	    private IParticipantData _participantData;

	    public ActivitiesController(IActivityData activityData, IUserData userData, IParticipantData participantData)
	    {
		    _activityData = activityData;
		    _userData = userData;
		    _participantData = participantData;
	    }

        public IActionResult Details(int id)
        {
	        Participant participant;
	        if (isUserParticipant(id))
	        {
		        participant = _participantData.Get(getUser().Id, id);
			}
	        else
	        {
		        participant = new Participant
		        {
			        Activity = _activityData.Get(id),
			        User = getUser()
		        };
	        }
	        var viewModel = new ActivityDetailsViewModel
	        {
		        Activity = _activityData.Get(id),
				IsUserParticipant = isUserParticipant(id),
				Participant = participant
	        };
	        return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ParticipantCreate(int activityId)
        {
	        if (ModelState.IsValid)
	        {
		        var participant = new Participant
		        {
					User = getUser(),
					Activity = _activityData.Get(activityId)
		        };
		        participant = _participantData.Add(participant);
		        return RedirectToAction("Details", "Activities", new { id = activityId });
	        }
	        else
	        {
		        return RedirectToAction("Index", "Home");
	        }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ParticipantDelete(int activityId)
        {
	        if (ModelState.IsValid)
	        {
		        _participantData.Delete(getUser().Id, activityId);
			}
			return RedirectToAction("Details", "Activities", new { id = activityId });
		}
		private User getUser()
        {
	        return _userData.GetUserByClaims(User.Claims);
        }

        private bool isUserParticipant(int activityId)
        {
	        return _participantData.GetByActivityId(activityId).Any(p => p.User.Id == getUser().Id);
        }

    }
}