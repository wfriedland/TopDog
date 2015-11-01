using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TopDog.Controllers
{
    public class peakPController : Controller
    {
        AddCookie cooke = new AddCookie();
        // GET: peakP
        public ActionResult Index()
        {
            cooke.peakProfits(this);
            return View();
        }

        public ActionResult BrainBalance()
        {
            return View();
        }
        public ActionResult choking()
        {
            return View();
        }
        public ActionResult jounaling()
        {
            return View();
        }
        public ActionResult learningChannels()
        {
            return View();
        }
        public ActionResult personalities()
        {
            return View();
        }
        public ActionResult PlayToWin()
        {
            return View();
        }
        public ActionResult recordResults()
        {
            return View();
        }
        public ActionResult riskSeekers()
        {
            return View();
        }

        public ActionResult fighter()
        {
            return View();
        }
        public ActionResult rationalist()
        {
            return View();
        }
        public ActionResult pragmatist()
        {
            return View();
        }
        public ActionResult visionary()
        {
            return View();
        }
        // GET: peakP/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: peakP/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: peakP/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: peakP/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: peakP/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: peakP/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: peakP/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
