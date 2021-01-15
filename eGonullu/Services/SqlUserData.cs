using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using eGonullu.Data;
using eGonullu.Models;
using Microsoft.EntityFrameworkCore;

namespace eGonullu.Services
{
	public class SqlUserData
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

		public bool Login(string userName, string password)
		{
			throw new NotImplementedException();
		}

		public User Update(User user)
		{
			_context.Attach(user).State = EntityState.Modified;
			_context.SaveChanges();
			return user;
		}
		
	}
}
