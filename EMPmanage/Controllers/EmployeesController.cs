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
        var employee=employeeList.FirstOrDefault(x=> x.Firstname==firstname);
        return View(employee);
    }
    public ActionResult Add(){
        return View();
    }
    [HttpPost]
    public ActionResult<string> Add(People people){
return "record saved";
    }
}
