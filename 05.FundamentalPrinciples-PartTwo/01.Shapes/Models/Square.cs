namespace _01.Shapes
{
   using System;
   public class Square : Rectangle
   {

      //Constructor
      public Square(double width)
         : base(width, width)
      {
      }

      //Method
      public override double CalculateSurface()
      {
         return this.Width * this.Width;
      }
   }
}
