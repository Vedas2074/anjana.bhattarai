using System;
public abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public void PrintDetails()
    {
        Console.WriteLine("Printing details for shape....");
    }

    public class Square : Rectangle
    {
        //base helps in calling the parent class
        public Square(double s):base(s,s){
            base.GetArea();
        }
                public double side { get; set; }
        public override double GetArea() => side * side;
        public override double GetPerimeter() => 4* side;
        
    }

    public class Rectangle : Shape // cant get inherited if we use sealed
    {
        public Rectangle(double l,double b){
            this.Length=l;
            this.Breadth=b;

        }
        public double Length { get; set; }
        public double Breadth { get; set; }
        public override double GetArea() => Length * Breadth;
        public override double GetPerimeter() => 2 * ( Length + Breadth);
        
    }

    public class Circle : Shape 
    {
        public double Radius { get; set; }
        public override double GetArea() => Math.PI * Radius * Radius;
        public override double GetPerimeter() => 2 * Math.PI * Radius;
        
    }


//multiple inheritance
    class A
    {

    }

    class B : A 
    {

    }

    class C : B 
    {

    }

    class D : A, IX 
    {

    }

    interface IX
    {

    }
    interface IY
    {

    }


}