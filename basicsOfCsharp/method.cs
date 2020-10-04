using System;
using System.Linq;
class Methods{
    void printInfo(){
        Console.WriteLine("print somthing");
        Multiply(2.4f,5.7f);
        Multiply(2.4f,5.7f,5.8f);
        Sum(4.6f,4.6f);
        Sum(4.6f,4.6f,5.7f);
        Greet("anjana");
        Greet("anjana","MR.");
        byte[] number={3,6,9,30,244};
       (byte,byte) result= Find MinMax(number);// if u dunt need min value we can write _ instead of byte min
       printCustomerDetails(age:33,name:"anjana",address:"djsfa",ismale:true);//named arg 

    }
    void printSonthing(string message){
        Console.WriteLine("message");

    }
    // to multiply two float numbers
    float Multiply(float firstnum, float secondnum){
        float product=firstnum*secondnum;
        return product;
    }
    float Multiply(float firstnum, float secondnum, float thirdnum){
        float product=firstnum*secondnum*thirdnum;
        return product;
    }// variable num of  arguments it can ccalll variable num of arguments using params keyword
    double Sum(params double[] numbers){
        double sum=0;
        foreach (double num in numbers){
            sum =sum+num;

        }
        return sum;
    }
    String Greet(string name,string prefix="miss."){

string fullname=prefix+","+name; //$"{prefix},{name}"; this is string interpolation(another way of concatenating)
return fullname;
    }

// returning multiple values:using  tuples
(byte,byte) Find MinMax(byte[] numbers){
    byte max=numbers.Max();
    byte min=numbers.Min;
    return (max,min);

}
void printCustomerDetails(string name,string address,byte age,bool ismale)
{
    Console.WriteLine($"{name}[{address}],{age}");
}
//expression bodied methods syntax
float Subtract(float firstnum, float secondnum, float thirdnum)=> firstnum-secondnum;//one line call of
}