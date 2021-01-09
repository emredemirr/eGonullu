using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eGonullu.Models;

namespace eGonullu.Services
{
	public interface IActivityData
	{
		IEnumerable<Activity> GetAll();
		IEnumerable<Activity> GetUserActivities(int userId);
		Activity Add(Activity activity);
		Activity Get(int id);
		Activity Update(Activity activity);

	}
}
