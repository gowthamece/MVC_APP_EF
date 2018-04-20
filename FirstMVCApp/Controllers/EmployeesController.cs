using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeeEntities db = new EmployeeEntities();

        public ActionResult JQAjax(Employee employee)
        {
            try
            {
                //return Json(new
                //{
                //    msg = "Successfully added " + employee.FirstName
                //});
                return Json(new { Employee=employee, JsonRequestBehavior.AllowGet });
                     
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        // GET: Employees
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
            //return Json(db.Employees.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetEmployees()
        {
            try
            {
                return Json(db.Employees.ToList(), JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json("false");
            }
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
      
        public ActionResult Create([Bind(Include = "EmployeeID,FirstName,LastName,Email,Password,Age")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeID,FirstName,LastName,Email,Password,Age")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.stp_UpdateEmpDetails(employee.EmployeeID, employee.FirstName, employee.LastName, employee.Email, employee.Password, employee.Age.ToString()); 
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult GetEmpFirstName(int id)

        {
           var temp= db.stp_Get_Emp_FirstName(id);
           return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
