namespace ShapeTracker.Models{
  public class Triangle{
    // Code for Triangle business logic will go here.
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    //constructor
    public Triangle(double side1, double side2, double side3){
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }
    public string findTriangleType(){
      if (Side1 == Side2 && Side2 == Side3 && Side3 == Side1)
      {
        return "Equilateral Triangle";
      }
      if (Side1 != Side2 && Side2 != Side3 && Side3 != Side1)
      {
        return "Scalene Triangle";
      }
      return "Isosceles Triangle";
    }
  }

  public class Rectangle{
    public double Length {get; set;}
    public double Width {get; set;}
    
    //constructor
    public Rectangle(double length, double width){
      Length = length;
      Width = width;
    }
    public double findArea(){
      double result = Length * Width;
      return result;
    }
  }
}