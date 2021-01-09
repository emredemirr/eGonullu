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
		IEnumerable<Participant> GetByActivityId(int activityId);
		Participant Add(Participant participant);
		Participant Get(int id);
		Participant Update(Participant participant);
	}
}
