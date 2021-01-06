using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace eGonullu.Controllers
{
    public class MyActivityController : Controller
    {
        // GET: MyActivity
        public IActionResult Index()
        {
            return View();
        }
    }
}