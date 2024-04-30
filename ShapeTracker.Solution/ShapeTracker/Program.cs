using System;
using System.Runtime.CompilerServices;
using ShapeTracker.Models;


namespace ShapeTracker{ 

  class Program{
    
    static readonly string[] UIshapeToEvaluate = new string[]{
      "Triangle Type",
      "Rectangle"
    };

    static void Main(){
      // entry point
      Console.WriteLine("~~~~~~~");
      // Triangle newTriangle = new Triangle(5, 19, 39);
      Console.WriteLine("Welcome to the Shape Tracker!");
      Console.WriteLine("What action would you like to take?");
      
      bool loopFlag = true;
      do {
        Console.WriteLine("\n1. Evaluate Triangle Type");
        Console.WriteLine("2. Find Area of Rectangle");
        Console.WriteLine("(enter a number without the period)");
        string result = Console.ReadLine();

        if (result == "1"){
          Console.WriteLine("\n~~ Evaluate Triangle ~~");
          Console.WriteLine("Please enter side 1:");
          double side1 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Please enter side 2:");
          double side2 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Please enter side 3:");
          double side3 = Convert.ToDouble(Console.ReadLine());

          Triangle newTriangle = new Triangle(side1, side2, side3);

          Console.WriteLine("\n~~ Triangle Type Results ~~");
          Console.WriteLine($"Side 1: {side1}");
          Console.WriteLine($"Side 2: {side2}");
          Console.WriteLine($"Side 3: {side3}");
          Console.WriteLine($"This is an {newTriangle.findTriangleType()}");
        }
        if (result == "2"){
          Console.WriteLine("\n~~ Area of Rectangle ~~");
          Console.WriteLine("Please enter Rectangle Length:");
          double length = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Please enter Rectangle Width:");
          double width = Convert.ToDouble(Console.ReadLine());

          Rectangle newRectangle = new Rectangle(length, width);

          Console.WriteLine("\n~~ Rectangle Area Results ~~");
          Console.WriteLine($"Length: {length}");
          Console.WriteLine($"Width: {width}");
          Console.WriteLine($"{length} X {width}");
          Console.WriteLine($"Rectangle Area: {newRectangle.findArea()}");
        }

        Console.WriteLine("Would you like to evaluate another shape? (y/n)");
        string loopAgain = Console.ReadLine();
        if (loopAgain == "y"){
          continue;
        }
        else {
          loopFlag = false;
        }
      }
      while (loopFlag == true);

      Console.WriteLine("\nGoodbye!");
      
      Console.WriteLine("\n~~~~~~~");

    }
  }
}