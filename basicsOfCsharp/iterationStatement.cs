using System;
class IterationStatement
{
    //pascal case:IterationStatement
    //camel case:iterationStatement
    public static void Main()
    {

        IterationStatement iterate = new IterationStatement();
        iterate.LearnForLoops();
    }
    void LearnForLoops()
    {
        int i;
        for (i = 0; i <= 10; i++)
        {
            Console.WriteLine("hello world");
        }

        int[] number = { 3, 5, 7, 8, 0, 1 };
        for (int x = 0; x < number.Length; x++)
        {

            Console.WriteLine(number[x]);
        }
    }
        //another method instead of looping

//         foreach(int num in number){

//         Console.WriteLine(num);
//         }

// foreach (int numb in number)
// {
//     if (numb % 2 == 0)
//     {
//         Console.WriteLine("even numbers are:");
//         Console.WriteLine(numb);
//     }
// }

void LearnWhileLoops()
{
    string confirm = "Y";
    while (confirm == "Y")
    {
        Console.WriteLine("hello world");
        Console.WriteLine("do u want it one more time?");
        confirm = Console.ReadLine();

    }
}}
// string confirm1 = "y";
// do
// {
//     Console.WriteLine("hello world");
//     Console.WriteLine("want to print one more time");
//     confirm1 = Console.ReadLine();

// } while (confirm1 == "y");
//     }