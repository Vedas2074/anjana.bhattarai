using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class People
{
    public int SN { get; set; }

    [Display( Name="First Name")]
     [Required(ErrorMessage="firstname is required")] 
    public string Firstname { get; set; }// to insert default value then we use }
    [Display( Name="Last Name")]
     [Required(ErrorMessage="lastname is required")] 
    public string Lastname { get; set; }
   
    public string Address { get; set; }

    public char? Gender { get; set; }
    public double? Salary { get; set; }// ?this makes nullable
    public static List<People> GetEmployes()
    { People emp1 = new People(){Firstname = "anjana",Lastname = "bhatt",Gender = 'F', Address = "dhpakhel",Salary = 32322.0 };
    //obj initializes
     People emp2 = new People()//obj initializes
     { SN=2,Firstname = "anjana",Lastname = "bhatt", Gender = 'F', Address = "dhpakhel", Salary = 32322.0 };
    People emp3 = new People()//obj initializes
    { SN=3,Firstname = "anjana", Lastname = "bhatt", Gender = 'F', Address = "dhpakhel", Salary = 32322.0 };
     People emp4 = new People()//obj initializes
    { SN=4, Firstname = "anjana", Lastname = "bhatt",Gender = 'F', Address = "dhpakhel", Salary = 32322.0};
    List<People> employeeList = new List<People>() { emp1, emp2, emp3, emp4 };
        
        return employeeList;
    }
}