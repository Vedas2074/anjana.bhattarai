using System;
using System.Collections.Generic; 
using System.Text;

namespace ClassAndObject
{
class Class
{
public string message = "This is a class item. It can be accessed from an object";
 private string secret_message = "This is secret message and can be accessed through method only";
public void print_secret()
{
Console.WriteLine(secret_message);
}
}
}


