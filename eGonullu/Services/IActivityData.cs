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
		IEnumerable<Activity> GetUserActivities(string userId);
		public IEnumerable<Activity> GetByCityAndState(string city, string state);
		public IEnumerable<Activity> GetByCity(string city);
		public IEnumerable<Activity> GetJoinedActivities(string userId);
		Activity Add(Activity activity);
		Activity Get(int id);
		Activity Update(Activity activity);

	}
}
