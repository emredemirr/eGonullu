using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eGonullu.Data;
using eGonullu.Models;
using Microsoft.EntityFrameworkCore;

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

		public IEnumerable<Activity> GetUserActivities(string userId)
		{
			return _context.Activities.Where(a => a.User.Id == userId);
		}

		public Activity Add(Activity user)
		{
			throw new NotImplementedException();
		}

		public Activity Get(int id)
		{
			return _context.Activities
				.Include(a => a.User)
				.Include(a => a.Participants)
				.ThenInclude(participant => participant.User)
				.SingleOrDefault(a => a.Id == id);
		}

		public Activity Update(Activity user)
		{
			throw new NotImplementedException();
		}
	}
}
