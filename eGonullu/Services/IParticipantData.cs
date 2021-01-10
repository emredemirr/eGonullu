using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eGonullu.Models;

namespace eGonullu.Services
{
	public interface IParticipantData
	{
		IEnumerable<Participant> GetAll();
		public void Delete(string userId, int activityId);
		IEnumerable<Participant> GetByActivityId(int activityId);
		Participant Add(Participant participant);
		Participant Get(string userId, int activityId);
		Participant Update(Participant participant);
	}
}
