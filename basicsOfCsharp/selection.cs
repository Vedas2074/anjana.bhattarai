using System;
class SelectionStatement{
     public void learnIfElse()
     {
         byte age=70;
         if (age>60){
             Console.WriteLine("you are old");
         }
         else{
             Console.WriteLine("you are not old");
         }
     }
     public void LearnSwitchCase(){
         Console.WriteLine("enter your hobby");
         string hobby=Console.ReadLine();
         switch(hobby){
             case "books":
                Console.WriteLine("rad well");
             break;
             case "cards":
             Console.WriteLine("play well");
             break;
             default:
             Console.WriteLine("no hobby");
             break;

         }
     }

}