using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eGonullu.Models
{
	public class Activity
	{
		public int Id { get; set; }

		[Required, MaxLength(80)]
		public string Name { get; set; }
		public string PictureUrl { get; set; }
		public string Title { get; set; }
		public string Definition { get; set; }
		public DateTime ActivityDate { get; set; }

		[Required, MaxLength(30)]
		public string City { get; set; }

		[Required, MaxLength(30)]
		public string State { get; set; }

		public string AddressDetail { get; set; }
		public int UserId { get; set; }
		public List<Participant> Participants { get; set; }
	}
}
