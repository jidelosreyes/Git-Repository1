using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.Git_Programacion2.Controllers.MVC
{
    public class GitProgramacion2Controller : Controller
    {
        // GET: GitProgramacion2
        public ActionResult Index()
        {
            return View();
        }

        // GET: GitProgramacion2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GitProgramacion2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GitProgramacion2/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GitProgramacion2/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GitProgramacion2/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GitProgramacion2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GitProgramacion2/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}