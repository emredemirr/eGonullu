using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eGonullu.ViewModels
{
	public class ActivityEditViewModel
	{
		[Required, MaxLength(80)]
		public string Name { get; set; }
		public string PictureUrl { get; set; }
		public string Definition { get; set; }
		public DateTime ActivityDate { get; set; }

		[Required, MaxLength(30)]
		public string City { get; set; }

		[Required, MaxLength(30)]
		public string State { get; set; }
	}
}
