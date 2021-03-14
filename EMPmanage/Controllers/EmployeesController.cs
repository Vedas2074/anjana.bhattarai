using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class EmployeesController : Controller
{
    public ActionResult Index()
    {   var employeeList=People.GetEmployes() ;
        return View(employeeList);
    } 
    public ActionResult Details(string firstname)
    {
        var employeeList=People.GetEmployes();
        var employee=employeeList.FirstOrDefault(x=> x.Fname==firstname);
        return View(employee);
    }
}
