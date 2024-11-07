using Portfolio.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Areas.Admin.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        // GET: Admin/Profile
        public ActionResult Index()
        {
            var a = Session["x"];
            var values = context.Admins.Where(x => x.Username == a).FirstOrDefault();
            return View(values);
        }
    }
}