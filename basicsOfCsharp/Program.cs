﻿using System;

    // class Program
    // {
    //     static void Main1()
    //     {
                      
    //         SelectionStatement select=new SelectionStatement();
    //         select.LearnSwitchCase();
    //          using System;
using LearningClasses;
using static Shape;

class Program
    {
        // static void Main(string[] args)
        // {
        //     // // Console.WriteLine("Hello World!");
        //     // // Console.WriteLine("Bipn is very good person.");
        //     // Console.WriteLine("What is Your name:");
        //     // string name = Console.ReadLine();

        //     // Console.WriteLine("Hello " + name);


        //     SelectionStatement selectionstatement = new SelectionStatement();
        //     selectionstatement.LearnIfElse();
        // }

        static void Main()
        {
            // var person = new Person("Bipin", "Dang", 22);
            // person.
            // person.Age = 22;

            var x = Calculator.Sum<int>(25 , 30);



            // Rectangle rectangle = new Rectangle();
            // rectangle.Length = 23.6;
            // rectangle.Breadth = 6.32;
            // var result = rectangle.GetArea();

        // another way
            Rectangle r =new Rectangle(22.5,77);
            Rectangle r1 =new Rectangle(12.5,77);
            var rarea=r.GetArea();
            var r1area=r1.GetArea();
            Square s=new Square(55.6);
            var sperimeter=s.GetPerimeter();
             Circle  c=new Circle(44.3);
             var sarea=c.GetArea();


        }

    }


        }
        
        
    }
