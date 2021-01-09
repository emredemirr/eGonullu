using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using eGonullu.Models;

namespace eGonullu.Services
{
	public interface IUserData
	{
		IEnumerable<User> GetAll();
		User GetUserByClaims(IEnumerable<Claim> claims);
		User Add(User user);
		User Get(int id);
		User Update(User user);
	}
}
