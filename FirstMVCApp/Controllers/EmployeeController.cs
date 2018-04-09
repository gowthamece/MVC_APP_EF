
using FirstMVCApp.ActionFilter;
using FirstMVCApp.Models;
using FirstMVCApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApp.Controllers
{
    //[LogActionFilter]
    //public class EmployeeController : Controller
    //{

    //    // GET: Employee
    //    [HttpGet]
    //    public ActionResult Index()
    //    {
    //        Employee employee = new Employee();
    //        //employee.FirstName = "Gowtham";
    //        //employee.LastName = "K";
    //        //employee.Age = "26";
    //        return View("EmployeeIndex", employee);
    //    }

    //    [HttpGet]
    //    public ActionResult ViewIndex()
    //    {
    //        List<Employee> employees = new List<Employee>();
    //        employees.Add(new Employee { FirstName = "Arun", LastName = "Raj" });
    //        employees.Add(new Employee { FirstName = "Pradeep", LastName = "Kumar" });
    //        ViewData["Employee"] = employees;
    //        ViewData["Demo"] = "Hello";
    //        ViewBag.Employee = employees;
    //        TempData["Emp"] = employees; //Session 
    //        return View();
    //    }
    //    [HttpGet]
    //    public ActionResult GetAllEmpDetails()
    //    {

    //        EmployeeRepository EmpRepo = new EmployeeRepository();
    //        ModelState.Clear();
    //        return View(EmpRepo.GetAllEmployees());
    //    }
    //    [HttpPost]
    //    public ActionResult AddEmployee(Employee employee)
    //    {
            
    //        if (ModelState.IsValid)
    //        {
    //            EmployeeRepository EmpRepo = new EmployeeRepository();

    //            if (EmpRepo.AddEmployee(employee))
    //            {
    //                ViewBag.Message = "Employee details added successfully";
    //            }
    //            return RedirectToAction("GetAllEmpDetails");
    //        }
    //        else
    //        {
    //            return View("EmployeeIndex");
    //        }
    //    }

    //    public ActionResult EditEmpDetails(int id)
    //    {
    //        EmployeeRepository EmpRepo = new EmployeeRepository();



    //        return View(EmpRepo.GetAllEmployees().Find(Emp => Emp.EmployeeID == id));

    //    }
    //    [HttpPost]

    //    public ActionResult EditEmpDetails(int id, Employee obj)
    //    {
    //        try
    //        {
    //            EmployeeRepository EmpRepo = new EmployeeRepository();

    //            EmpRepo.UpdateEmployee(obj);

    //            return RedirectToAction("GetAllEmpDetails");
    //        }
    //        catch
    //        {
    //            return View();
    //        }
    //    }

    //    // GET: Employee/DeleteEmp/5    
    //    public ActionResult DeleteEmp(int id)
    //    {
    //        try
    //        {
    //            EmployeeRepository EmpRepo = new EmployeeRepository();
    //            if (EmpRepo.DeleteEmployee(id))
    //            {
    //                ViewBag.AlertMsg = "Employee details deleted successfully";

    //            }
    //            return RedirectToAction("GetAllEmpDetails");

    //        }
    //        catch
    //        {
    //            return View();
    //        }
    //    }
    //    [HttpGet]
    //    public ActionResult PartialDemoTemp()
    //    {
    //        var result = TempData["Emp"];
    //        return View("PartialDemo");
    //    }

    //    [HttpGet]

    //    [OutputCache(Duration = 15)]
    //    public ActionResult GetDate()
    //    {
    //        return Content(DateTime.Now.ToLocalTime().ToString());
    //    }


    //}
}