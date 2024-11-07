using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Context;
using Portfolio.Entities;
namespace Portfolio.Areas.Admin.Controllers
{
    public class ProjectsController : Controller
    {
        
        PortfolioContext context = new PortfolioContext();
        // GET: Admin/Projects
        [Authorize]
        public ActionResult ProjectsList()
        {
            var values = context.Projects.ToList();
            return View(values);
        }

        public ActionResult CreateProjects()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(Project project)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    context.Projects.Add(project);
                    context.SaveChanges();
                    return RedirectToAction("ProjectsList", "Projects", "Admin");
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını loglayabilir veya görüntüleyebilirsiniz
                ModelState.AddModelError("", "Bir hata oluştu: " + ex.Message);
            }
            return View(project);
        }

        public ActionResult DeleteProjects(int id)
        {
            var value = context.Projects.Find(id);
            context.Projects.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ProjectsList", "Projects", "Admin");
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var value = context.Projects.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProject(Project project)
        {
            var value = context.Projects.Find(project.ProjectId);
            value.ProjectName = project.ProjectName;
            value.Description = project.Description;
            value.Photo=project.Photo;

            context.SaveChanges();
            return RedirectToAction("ProjectsList", "Projects", "Admin");

        }
    }
}