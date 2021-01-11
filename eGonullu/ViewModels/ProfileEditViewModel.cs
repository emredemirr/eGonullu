using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eGonullu.ViewModels
{
	public class ProfileEditViewModel
	{
		[Required]
		[MaxLength(30)]
		public string Name { get; set; }

		[Required]
		[MaxLength(30)]
		public string LastName { get; set; }
		
		[StringLength(11)]
		public string Tc { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }
		
		[Phone]
		public string Phone { get; set; }
	}
}
