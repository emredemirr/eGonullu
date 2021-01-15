using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using eGonullu.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;

namespace eGonullu.Services
{
	public class HttpUserData : IUserData
	{
		public async Task<User> Get(int userId)
		{
			User user = null;
			try
			{
				string url = "http://localhost:3003/user?user_id=" + userId;
				HttpClient client = new HttpClient();
				var response = await client.GetAsync(url);
				var responseString = await response.Content.ReadAsStringAsync();
				var parsed = JObject.Parse(responseString);
				if ((int)parsed["statusCode"] == 200)
				{
					user = new User
					{
						Email = (string)parsed["Email"],
						Facebook = (string)parsed["Facebook"],
						Instagram = (string)parsed["Instagram"],
						Twitter = (string)parsed["Twitter"],
						Name = (string)parsed["Name"],
						LastName = (string)parsed["LastName"],
						Id = (int) parsed["Id"],
						PictureUrl = (string)parsed["PictureUrl"],
						Phone = (string)parsed["Phone"],
						Tc = (string)parsed["Tc"],
						WebSite = (string)parsed["WebSite"],
					};
				}

			}
			catch (HttpRequestException e)
			{
				Console.WriteLine(e.ToString());
			}
			return user;
		}

		public async Task<bool> Add(User user)
		{

			HttpClient client = new HttpClient();
			var values = new Dictionary<string, string>
			{
				{ "Tc", user.Tc },
				{ "Name", user.Name },
				{ "LastName", user.LastName },
				{ "Email", user.Email },
				{ "Phone", user.Phone },
				{ "PictureUrl", user.PictureUrl },
				{ "Twitter", user.Twitter },
				{ "WebSite", user.WebSite },
				{ "Instagram", user.Instagram },
				{ "Facebook", user.Facebook },
			};
			var content = new FormUrlEncodedContent(values);
			var response = await client.PostAsync("http://localhost:3003/register", content);
			var responseString = await response.Content.ReadAsStringAsync();
			var parsed = JObject.Parse(responseString);

			return (int)parsed["statusCode"] == 200;
		}

		public async Task<bool> Login(string userName, string password)
		{
			HttpClient client = new HttpClient();
			var values = new Dictionary<string, string>
			{
				{ "userName", userName },
				{ "password", password },
			};
			var content = new FormUrlEncodedContent(values);
			var response = await client.PostAsync("http://localhost:3003/login", content);
			var responseString = await response.Content.ReadAsStringAsync();
			var parsed = JObject.Parse(responseString);
			if ((int)parsed["statusCode"] == 200)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		public async Task<bool> Update(User user)
		{

			HttpClient client = new HttpClient();
			var values = new Dictionary<string, string>
			{
				{ "Id", user.Id.ToString() },
				{ "Tc", user.Tc },
				{ "Name", user.Name },
				{ "LastName", user.LastName },
				{ "Email", user.Email },
				{ "Phone", user.Phone },
				{ "PictureUrl", user.PictureUrl },
				{ "Twitter", user.Twitter },
				{ "WebSite", user.WebSite },
				{ "Instagram", user.Instagram },
				{ "Facebook", user.Facebook },
			};
			var content = new FormUrlEncodedContent(values);
			var response = await client.PostAsync("http://localhost:3003/update_user", content);
			var responseString = await response.Content.ReadAsStringAsync();
			var parsed = JObject.Parse(responseString);

			if ((int)parsed["statusCode"] == 200)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
