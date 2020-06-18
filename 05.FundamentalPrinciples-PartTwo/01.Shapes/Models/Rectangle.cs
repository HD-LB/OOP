namespace _01.Shapes
{
   using System;
   public class Rectangle : Shape
   {
      public Rectangle(double width, double height) 
         : base(width, height)
      {
      }

      //Abstract Methods Implementation
      public override double CalculateSurface()
      {
         return this.Width * this.Height;
      }
   }
}
