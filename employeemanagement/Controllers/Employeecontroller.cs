using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class EmployeeController : Controller
{
    public ActionResult Index()// or we can put value by objname.firstname blah.....
       
    {   //object initializzer syntax    
        var employee=Person.GetPerson();
        return View(employee);


    }
    public ActionResult Detail(string Firstname){
        var emp=Person.GetPerson();
        var employees=emp.Where(x=>x. Firstname==Firstname).First();
         
    
        return View(employees);
    }
    public ActionResult Add(){
        return View();

    }
   // Controller binding techniques
    [HttpPost]
    public ActionResult<string> Add([FromForm]Person person){
        return "record saved";

    }
    
}