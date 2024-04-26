# Shape Tracker Console App

## Business Requirements

User selects what shape they would like to evaluate:
- Triangle Type
- Area of a Rectangle

### Triangle Type
User is prompted to enter the sides of each triangle side
The type of triangle is displayed along with the sides they entered. 

#### Types:
- Equilateral triangle: All three sides are equal in length
- Scalene triangle: All three sides are different lengths
- Isosceles triangle: Two sides are the same length

### Area of a Rectangle
User is prompted to enter the length and width of a rectangle
The area of the rectangle is displayed along with the length and width they entered


## Technical Requirements
- C# .NET Console App
- a Program class with a Main Function that will call our inital UI code
- a UI class that will display options to the user
- a Data class that will store data the user seleciton
- a Triangle class that calculates the type of triangle given three sides. 
  - an eval method for evaluation that will return the triangle type.
- a Rectangle class that calculates the area of a rectangle given two sides.
  - a calcArea method that will return the area of a rectangle

## Out of Scope
- triangle types that include angle measurements. This program only measures sides
- calculating the area of a triangle. We are only calculating area of rectangles
- data storage, users will not be able to view previous entries during their session
