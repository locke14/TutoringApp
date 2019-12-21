using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TutoringApp.API.Dtos
{
	public class UserForRegisterDto
	{
		[Required]
		public string Username { get; set; }

		[Required]
		[StringLength(8, MinimumLength = 4, ErrorMessage = "Specify between 4 and 8 chars)")]
		public string Password { get; set; }

	}
}
