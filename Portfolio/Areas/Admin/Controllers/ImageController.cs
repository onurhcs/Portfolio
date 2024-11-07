using Portfolio.Context;
using Portfolio.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Areas.Admin.Controllers
{
    public class ImageController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        // GET: Admin/Image
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ImageAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ImageAdd(Project p)
        {
            if (Request.Files.Count > 0)
            {
                string dosyaadi=Path.GetFileName(Request.Files[0].FileName);
                string uzanti=Path.GetExtension(Request.Files[0].FileName);
                string yol = "~/Image/" + dosyaadi + uzanti;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                p.Photo = "~/Image/" + dosyaadi + uzanti;
            }
            context.Projects.Add(p);
            context.SaveChanges();
            return View();
        }
    }
}