namespace ShapeTracker.Models{
  public class Triangle{
    // Code for Triangle business logic will go here.
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public Triangle(double side1, double side2, double side3){
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }
  }
}