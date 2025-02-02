﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Context;
using Portfolio.Entities;
namespace Portfolio.Controllers
{
    public class RegisterController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            context.Admins.Add(admin);
            context.SaveChanges();
            return RedirectToAction("Index","Login");
        }

    }
}