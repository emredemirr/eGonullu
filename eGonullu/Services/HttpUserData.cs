using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using eGonullu.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
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
				HttpClient client = new HttpClient();
				var values = new Dictionary<string, string>
				{
					{ "userId", userId.ToString() },
				};
				var content = new FormUrlEncodedContent(values);
				var response = await client.PostAsync("http://localhost:3003/users", content);
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
						Password = (string)parsed["Password"],
					};
				}

			}
			catch (HttpRequestException e)
			{
				Console.WriteLine(e.ToString());
			}
			return user;
		}

		public async Task<int> Add(User user)
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
				{ "Password", user.Password },
			};
			var content = new FormUrlEncodedContent(values);
			var response = await client.PostAsync("http://localhost:3003/register", content);
			var responseString = await response.Content.ReadAsStringAsync();
			var parsed = JObject.Parse(responseString);

			return (int)parsed["userId"];
		}

		public int Login(string email, string password)
		{
			var soapResponce = CreateSoapEnvelope(email, password).Result;
			if (GetSoapMessage(soapResponce, "statusCode") == "200")
			{
				return int.Parse(GetSoapMessage(soapResponce, "userId"));
			}

			return -1;
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
				{ "Password", user.Password },
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

		private async Task<string> CreateSoapEnvelope(string email, string password)
		{
			string soapString = $@"<?xml version=""1.0"" encoding=""utf-8""?>
				<soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:tns=""http://localhost:4004/wsdl"">
				  <soap:Body>
				    <tns:CheckLoginRequest>
				      <tns:email>{email}</tns:email>
				      <tns:password>{password}</tns:password>
				    </tns:CheckLoginRequest>
				  </soap:Body>
				</soap:Envelope>";

			HttpResponseMessage response = await PostXmlRequest("http://localhost:4004/wsdl", soapString);
			string content = await response.Content.ReadAsStringAsync();

			return content;
		}

		private static async Task<HttpResponseMessage> PostXmlRequest(string baseUrl, string xmlString)
		{
			using var httpClient = new HttpClient();
			var httpContent = new StringContent(xmlString, Encoding.UTF8, "text/xml");
			httpContent.Headers.Add("SOAPAction", "CheckLogin");

			return await httpClient.PostAsync(baseUrl, httpContent);
		}

		public static string GetSoapMessage(string soapBody, string nodeName)
		{
			XNamespace soapNameSpace
				= XNamespace.Get("http://tempuri.org/");
			var document = XDocument.Parse(soapBody);

			var soapMessage = document?.Root?.Descendants()?.Where(p =>
				p.Name.LocalName.Equals(nodeName) && p.Name.Namespace
				== soapNameSpace)?.FirstOrDefault()?.FirstNode?.ToString();
			

			return soapMessage;
		}
	}
}
