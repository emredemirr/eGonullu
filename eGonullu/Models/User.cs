using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eGonullu.Models
{
	public class User
	{
		public int Id { get; set; }
		
		public string Tc { get; set; }

		[Required]
		[MaxLength(30)]
		public string Name { get; set; }

		[Required]
		[MaxLength(30)]
		public string LastName { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Phone]
		public string Phone { get; set; }

		[Url]
		public string PictureUrl { get; set; }

		[Required]
		public string Password { get; set; }

		public string Twitter { get; set; }
		public string WebSite { get; set; }
		public string Instagram { get; set; }
		public string Facebook { get; set; }
	}
}
