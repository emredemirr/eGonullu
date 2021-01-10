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

		public User GetUserByClaims(IEnumerable<Claim> claims)
		{
				var uniqueId = claims.SingleOrDefault(c =>
						c.Type.EndsWith("nameidentifier"))
					?.Value;

				return _context.Users.Include(u => u.Activities).SingleOrDefault(u => u.Id == uniqueId);
		}

		public User Add(User user)
		{
			_context.Users.Add(user);
			_context.SaveChanges();
			return user;
		}

		public User Get(string id)
		{
			throw new NotImplementedException();
		}

		public User Update(User user)
		{
			throw new NotImplementedException();
		}
		
	}
}
