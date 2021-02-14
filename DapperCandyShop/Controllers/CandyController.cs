using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperCandyShop.Controllers
{
    public class CandyController : Controller
    {
        // GET: CandyController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CandyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CandyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CandyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: CandyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CandyController/Edit/5
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

        // GET: CandyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CandyController/Delete/5
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
