using System;
using ShapeTracker.Models;


namespace ShapeTracker{ 
  class Program{
    static void Main(){
      // entry point
      Console.WriteLine("~~~~~~~");
      Console.WriteLine("Everything is working 👌");

      Triangle newTriangle = new Triangle();
      Console.WriteLine(newTriangle); //prints object type

      
      Console.WriteLine("\n\n\n~~~~~~~");

    }
  }
}