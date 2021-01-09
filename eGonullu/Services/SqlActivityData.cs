using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eGonullu.Data;
using eGonullu.Models;

namespace eGonullu.Services
{
	public class SqlActivityData : IActivityData
	{
		private readonly EGonulluDbContext _context;

		public SqlActivityData(EGonulluDbContext context)
		{
			_context = context;
		}
		public IEnumerable<Activity> GetAll()
		{
			return _context.Activities.OrderBy(a => a.Name);
		}

		public IEnumerable<Activity> GetUserActivities(int userId)
		{
			return _context.Activities.Where(a => a.User.Id == userId);
		}

		public Activity Add(Activity user)
		{
			throw new NotImplementedException();
		}

		public Activity Get(int id)
		{
			throw new NotImplementedException();
		}

		public Activity Update(Activity user)
		{
			throw new NotImplementedException();
		}
	}
}
