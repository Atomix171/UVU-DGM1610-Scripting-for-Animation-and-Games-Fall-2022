using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string firstname = "Vryan";
      string lastname = "Arias";
      
      Console.WriteLine("Dave: Hello what is your name sir?");
      Console.WriteLine("Vryan: Hi! my name is " + firstname +" "+lastname+".");
      
      Console.WriteLine("Dave: Do you by anychance have a online gamertag as well how old are you?");
      string onlinename = "Vryan: Atomix";
      const int age = 20;
      Console.WriteLine("Vryan: I do my username is "+onlinename+"and I am "+age+" years old.");
      
      Console.WriteLine("Dave: I'm going to be asking you just one math question that I'm having trouble with if that fine?");
      Console.WriteLine("Vryan: hit me.");
      
      Console.WriteLine("Dave: What is 12 x 5? Math isn't my strong suit.");
      
      int x = 12, y = 5;
      int total = x * y;
      Console.WriteLine("Vryan: No worries yeah that is "+total);
      
      Console.WriteLine("Dave: And by any chance do you know what is pie agian and can you add 5.56?");
      

      float pie = 3.14f;
      double mydoublenum = 5.56D;
      double doubletotal = pie + mydoublenum; 
      Console.WriteLine("Vryan: Yeah that would be "+doubletotal);
      
      bool correctb = true;
      bool wrongd = false;
      char wrongletter = 'b';
      char correctletter = 'd';
      
      Console.WriteLine("Dave: Im going to be giving you a letter you will get the letter" +correctletter);
      Console.WriteLine("Vryan: Sorry did you say "+wrongletter);
      Console.WriteLine("Dave: "+wrongd+ " you have" +correctletter);
      Console.WriteLine("Vryan: Cool " +correctletter);
      Console.WriteLine("Dave: "+correctb);

     }
  }
}
