using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//      @Html.ActionLink("Be More", "Index", "TopDog", null, new{title = "Be More",@class = "btn-info",style = "background-image: url('~/Resources/button1.jpg')")

namespace TopDog.Controllers
{
    public class TopDogController : Controller
    {
        AddCookie cooke = new AddCookie();
        // GET: TopDog
        public ActionResult Index()
        {
            cooke.topDog(this);
            return View();
        }

        public ActionResult indicator()
        {
            return View();
        }

        // GET: TopDog/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TopDog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TopDog/Create
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

        // GET: TopDog/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TopDog/Edit/5
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

        // GET: TopDog/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TopDog/Delete/5
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
