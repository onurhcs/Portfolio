using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Context;
using Portfolio.Entities;


namespace Portfolio.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        // GET: Admin/About
        [Authorize]
        public ActionResult AboutList()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
    }
}