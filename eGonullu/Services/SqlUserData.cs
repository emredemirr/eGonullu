using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eGonullu.Data;
using eGonullu.Models;

namespace eGonullu.Services
{
	public class SqlUserData : IUserData
	{
		private readonly EGonulluDbContext _context;

		public SqlUserData(EGonulluDbContext context)
		{
			_context = context;
		}
		public IEnumerable<User> GetAll()
		{
			return _context.Users;
		}

		public User Add(User user)
		{
			_context.Users.Add(user);
			_context.SaveChanges();
			return user;
		}

		public User Get(int id)
		{
			throw new NotImplementedException();
		}

		public User Update(User user)
		{
			throw new NotImplementedException();
		}
	}
}
