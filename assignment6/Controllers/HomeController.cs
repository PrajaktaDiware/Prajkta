using assignment6.Repository;
using assignment6.Repository.Entity;
using assignment6.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace assignment6.Controllers
{
    public class HomeController : Controller
    {
        private Employeecontext db = new Employeecontext();

        // GET: Home
        private readonly IEmployeeService employeeservice;

        public ActionResult Index()
        {
            return View(db.AEmployees.ToList());
        }
        public HomeController(IEmployeeService employeeService)
        {
            this.employeeservice = employeeService;
        }
        public ActionResult Create()
        {
            ViewBag.StateList = db.States;
            var model = new Emp1();
            return View(model); ;
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp1 emp = db.AEmployees.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email,Phone,MaritalStatus,State,City")] Emp1 emp)
        {
            if (ModelState.IsValid)
            {
                db.AEmployees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StateList = db.States;
            return View(emp);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp1 employee = db.AEmployees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,Phone,MaritalStatus,State,City")] Emp1 employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp1 emp = db.AEmployees.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Emp1 product = db.AEmployees.Find(id);
            db.AEmployees.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult FillCity(int state)
        {
            var cities = db.Cities.Where(c => c.StateId == state);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }

    }
}