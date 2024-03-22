﻿using CLDV_ASSIGNMENT.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLDV_ASSIGNMENT.Controllers
{
	public class UserController1 : Controller
	{
		public CloudTable1 usrtbl = new CloudTable1();

		[HttpPost]
		public ActionResult About(CloudTable1 Users)
		{
			var result = usrtbl.insert_User(Users);
			return RedirectToAction("Privacy", "Home");
		}

		[HttpGet]
		public ActionResult About()
		{
			return View(usrtbl);
		}
	}
}