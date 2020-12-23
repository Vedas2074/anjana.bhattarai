using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public class Person{
    [Required(ErrorMessage="Firstnameis required")]
    [Display(Name ="First Name")]
        public string Firstname{get;set;}

        [Required]
        [Display(Name ="Last Name")]
        public string Lastname{get;set;}
        public string Addressname{get;set;}
        public string? Gender{get;set;}="M";
        public double? Contact{get;set;}
        public double? Salary{get;set;}
        public static List<Person>GetPerson(){

        
        Person emp1=new Person(){Firstname="Anjana",Lastname="Bhattarai", Addressname="Dhapakhel", Gender="M", Salary=2000, Contact=3748237};
        Person emp2=new Person(){Firstname="Barsha",Lastname="Lama", Addressname="Satdobato",  Salary=3000, Contact=3746237};
        Person emp3=new Person(){Firstname="Hari",Lastname="Bhatt", Addressname="Lagankhel",  Salary=4000, Contact=37482537};
        Person emp4=new Person(){Firstname="Arun",Lastname="Shrestha", Addressname="Jawalekhel",  Salary=5000, Contact=37248237};
        Person emp5=new Person(){Firstname="pragati",Lastname="Rai", Addressname="Talchikhel",  Salary=20050, Contact=37485237};
        var employees=new List<Person>{emp1,emp2,emp3,emp4,emp5};
           return employees;
    }

    internal static object Where(Func<object, bool> p)
    {
        throw new NotImplementedException();
    }

    internal static object FirstOrDefault(Func<object, bool> p)
    {
        throw new NotImplementedException();
    }

    internal static object FirstorDefault(Func<object, bool> p)
    {
        throw new NotImplementedException();
    }
}