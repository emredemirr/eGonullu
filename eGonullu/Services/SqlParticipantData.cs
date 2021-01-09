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
		public IEnumerable<Participant> GetAll()
		{
			throw new NotImplementedException();
		}

		public Participant Add(Participant user)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Participant> GetByActivityId(int activityId)
		{
			return _context.Participants
				.Include(p => p.Activity)
				.Include(p => p.User)
				.Where(p => p.Activity.Id == activityId);
		}
		public Participant Get(int id)
		{
			throw new NotImplementedException();
		}

		public Participant Update(Participant user)
		{
			throw new NotImplementedException();
		}
	}
}
