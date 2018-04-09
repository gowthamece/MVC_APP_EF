using FirstMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApp.Controllers
{
    public class DepartmentsController : Controller
    {
        // GET: Departments
        private CustomerContext db = new CustomerContext(); 
        public ActionResult Index()
        {
            return View(db.Departments.ToList());
        }
        public ActionResult DepartmentForm()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DepartmentForm([Bind(Include = "DepratmentName")] Department department)
        {
            if (ModelState.IsValid)
            {
                using (var context = new CustomerContext())
                    {
                    SqlParameter param1 = new SqlParameter("@DeptName", department.DepratmentName);
                    //SqlParameter param2 = new SqlParameter("@DeptID", department.DepartmentID);
                    var departments = context.Database.ExecuteSqlCommand("stp_InsertDepartment @DeptName", param1);
                    context.Departments.Add(department);
                     context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View("Index");
                     
        }
    }
}