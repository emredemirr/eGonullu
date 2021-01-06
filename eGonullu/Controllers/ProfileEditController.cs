using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace eGonullu.Controllers
{
    public class ProfileEditController : Controller
    {
        // GET: ProfileEdit
        public IActionResult Index()
        {
            return View();
        }
    }
}