using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eGonullu.Models;

namespace eGonullu.ViewModels
{
	public class HomeIndexViewModel
	{
		public IEnumerable<Activity> Activities { get; set; }
		public User User { get; set; }
	}
}
