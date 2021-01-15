using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eGonullu.Models;

namespace eGonullu.Services
{
	public interface IParticipantData
	{
		public void Delete(int userId, int activityId);
		IEnumerable<Participant> GetByActivityId(int activityId);
		Participant Add(Participant participant);
		Participant Get(int userId, int activityId);
	}
}
