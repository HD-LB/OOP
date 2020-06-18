//•Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//•Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure(height* width for rectangle and height* width/2 for triangle).
//•Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
//•Write a program that tests the behaviour of the CalculateSurface() method for different shapes(Square, Rectangle, Triangle) stored in an array.


namespace _01.Shapes
{
   using System;
   using System.Collections.Generic;
   using System.Linq;


   public class ShapesMain
   {
      static void Main()
      {
         var shapes = new Shape[]
         {
            new Triangle(4.5, 8.9),
            new Rectangle(2.9, 9.6),
            new Circle(5.8)

         };

         foreach (var sh in shapes)
         {
            Console.WriteLine("{0} surface is {1}.", sh.GetType().Name, sh.CalculateSurface());
         }
      }
   }
}
