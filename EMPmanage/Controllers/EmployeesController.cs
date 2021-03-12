using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
public class EmployeesController : Controller
{
    public ActionResult Index()
    {

        People emp1 = new People()//obj initializes
        {   SN=1,
            Fname = "anjana",
            Lname = "bhatt",
            Gender = 'F',
            Address = "dhpakhel",
            Salary = 32322.0

        };
        People emp2 = new People()//obj initializes
        { SN=2,
            Fname = "anjana",
            Lname = "bhatt",
            Gender = 'F',
            Address = "dhpakhel",
            Salary = 32322.0

        };
        People emp3 = new People()//obj initializes
        { SN=3,
            Fname = "anjana",
            Lname = "bhatt",
            Gender = 'F',
            Address = "dhpakhel",
            Salary = 32322.0

        };
        People emp4 = new People()//obj initializes
        { SN=4,
            Fname = "anjana",
            Lname = "bhatt",
            Gender = 'F',
            Address = "dhpakhel",
            Salary = 32322.0
        };
        List<People> employeeList = new List<People>() { emp1, emp2, emp3, emp4 };
        return View(employeeList);
    }
}
public class People
{
    public int SN { get; set; }
    public string Fname { get; set; }// to insert default value then we use }='ahfj';
    public string Lname { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; }
    public double Salary { get; set; }

}