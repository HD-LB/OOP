namespace _01.Shapes
{
   using System;

   public abstract class Shape
   {
      //Fields
      private double width;
      private double height;

      //Constructor
      public Shape(double width, double height )
      {
         this.Width = width;
         this.Height = height;
      }


      //Proparties
      public double Width
      {
         get { return this.width; }
         set
         {
            if (value <= 0)
            {
               throw new ArgumentException("The width cannot be negative or zero.");
            }
            else
            {
               this.width = value;
            }
         }
      }

      public double Height
      {
         get { return this.height; }
         set
         {
            if (value <= 0)
            {
               throw new ArgumentException("The height cannot be negative or zero.");
            }
            else
            {
               this.height = value;
            }
         }
      }

      //Abstract Methods
      public abstract double CalculateSurface();

   }
}
