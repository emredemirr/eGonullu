using System;
using System.Collections;
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
	        Activity activity = _activityData.Get(id);
	        Participant participant;
	        if (isUserParticipantToActivity(id))
	        {
		        participant = _participantData.Get(getUser().Id, id);
			}
	        else
	        {
		        participant = new Participant
		        {
			        Activity = activity,
			        UserId = getUser().Id
		        };
	        }

	        var participants = new List<User>();
	        foreach (var activityParticipant in activity.Participants)
	        {
		        participants.Add(_userData.Get(activityParticipant.UserId).Result);
	        }
	        var viewModel = new ActivityDetailsViewModel
	        {
		        Activity = activity,
				IsUserParticipant = isUserParticipantToActivity(id),
				Participant = participant,
				ActivityUser = _userData.Get(activity.UserId).Result,
				Participants = participants
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
					UserId = getUser().Id,
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
			var userId = HttpContext.Session.GetInt32("userId").GetValueOrDefault();
			return _userData.Get(userId).Result;
		}

        private bool isUserParticipantToActivity(int activityId)
        {
	        return _participantData.GetByActivityId(activityId).Any(p => p.UserId == getUser().Id);
        }

    }
}