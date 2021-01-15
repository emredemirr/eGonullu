﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using eGonullu.Models;

namespace eGonullu.Services
{
	public interface IUserData
	{
		Task<User> Get(int userId);
		Task<bool> Add(User user);
		Task<bool> Login(string userName, string password);
		Task<bool> Update(User user);
	}
}
