using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task_1.Areas.Identity.Data;
using task_1.Models.data;
using task_1.Models.repro;

namespace task_1.Controllers
{
    public class CertificationsController : Controller
    {
        // GET: CertificationsController
        irep<certifications, task_1User> repo;
        public CertificationsController(irep<certifications, task_1User> repocertfic)
        {
            this.repo = repocertfic;
            
        }
        public ActionResult Index()
        {
          var certification=  repo.get();
            return View(certification);
        }

        // GET: CertificationsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CertificationsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CertificationsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int id, string name, List<task_1User> users)
        {
            try
            {
                //dbcontext.certification.Add(new certifications { id = id, name = name, user = users });
                //dbcontext.SaveChanges();
                repo.add(id, name, users);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
                //return View();
            }
        }

        // GET: CertificationsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CertificationsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CertificationsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CertificationsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
