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

		public IEnumerable<Activity> GetByCityAndState(string city, string state)
		{
			return _context.Activities.Where(a => a.City == city && a.State == state);
		}
		public IEnumerable<Activity> GetByCity(string city)
		{
			return _context.Activities.Where(a => a.City == city);
		}
		public IEnumerable<Activity> GetUserActivities(string userId)
		{
			return _context.Activities.Where(a => a.User.Id == userId);
		}

		public Activity Add(Activity activity)
		{
			_context.Activities.Add(activity);
			_context.SaveChanges();
			return activity;
		}

		public Activity Get(int id)
		{
			return _context.Activities
				.Include(a => a.User)
				.Include(a => a.Participants)
				.ThenInclude(participant => participant.User)
				.SingleOrDefault(a => a.Id == id);
		}

		public Activity Update(Activity restaurant)
		{
			_context.Attach(restaurant).State = EntityState.Modified;
			_context.SaveChanges();
			return restaurant;
		}

		public IEnumerable<Activity> GetJoinedActivities(string userId)
		{
			return _context.Activities
				.Include(a => a.User)
				.Include(a => a.Participants)
				.ThenInclude(participant => participant.User)
				.Where(a => a.Participants.Any(p => p.User.Id == userId));
		}
	}
}
