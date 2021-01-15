using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eGonullu.Data;
using eGonullu.Models;
using Microsoft.EntityFrameworkCore;

namespace eGonullu.Services
{
	public class SqlParticipantData : IParticipantData
	{
		private readonly EGonulluDbContext _context;

		public SqlParticipantData(EGonulluDbContext context)
		{
			_context = context;
		}
		public Participant Add(Participant participant)
		{
			_context.Participants.Add(participant);
			_context.SaveChanges();
			return participant;
		}

		public void Delete(int userId, int activityId)
		{
			var participant = Get(userId, activityId);
			_context.Participants.Remove(participant);
			_context.SaveChanges();
		}

		public IEnumerable<Participant> GetByActivityId(int activityId)
		{
			return _context.Participants
				.Include(p => p.Activity)
				.Include(p => p.User)
				.Where(p => p.Activity.Id == activityId);
		}
		public Participant Get(int userId, int activityId)
		{
			return _context.Participants
				.Include(p => p.Activity)
				.Include(p => p.User)
				.SingleOrDefault(p => p.User.Id == userId && p.Activity.Id == activityId);
		}
	}
}
