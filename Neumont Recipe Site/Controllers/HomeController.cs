using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Neumont_Recipe_Site.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Recipe(string fileName)
		{
			ViewData["FileURL"] = fileName;
			return View();
		}
	}
}