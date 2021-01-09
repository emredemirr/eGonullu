using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGonullu.Models
{
	public class Activity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string PicturePath { get; set; }
		public string Definition { get; set; }
		public DateTime ActivityTime { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public User User { get; set; }
		public List<Participant> Participants { get; set; }
	}
}
