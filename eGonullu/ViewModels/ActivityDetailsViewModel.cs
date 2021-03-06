﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eGonullu.Models;

namespace eGonullu.ViewModels
{
	public class ActivityDetailsViewModel
	{
		public Activity Activity { get; set; }
		public User ActivityUser { get; set; }
		public bool IsUserParticipant { get; set; }
		public Participant Participant { get; set; }
		public IEnumerable<User> Participants { get; set; }
	}
}
