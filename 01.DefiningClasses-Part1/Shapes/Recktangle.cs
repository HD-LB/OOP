using System;

namespace Shapes
{
   public class Recktangle
   {
      //Constructor
      public Recktangle(double width, double height)
      {
         this.Width = width;
         this.Height = height;
      }

      
      //Properties
      public double Width { get; set; }

      public double Height { get; set; }

      public double Area
      {
         get
         {
            return this.Width * this.Height;
         }
      }
   }
}
