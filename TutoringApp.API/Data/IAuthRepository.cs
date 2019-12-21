using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutoringApp.API.Models;

namespace TutoringApp.API.Data
{
	public interface IAuthRepository
	{
		public Task<User> Register(User user, string password);
		public Task<User> Login(string username, string password);
		public Task<bool> UserExists(string username);
	}
}
