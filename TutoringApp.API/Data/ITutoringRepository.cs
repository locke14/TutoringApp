using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutoringApp.API.Models;

namespace TutoringApp.API.Data
{
	public interface ITutoringRepository
	{
		void Add<T>(T entity) where T : class;
		void Delete<T>(T entity) where T : class;
		Task<bool> SaveAll();
		Task<IEnumerable<User>> GetUsers();
		Task<User> GetUser(int id);
	}
}
