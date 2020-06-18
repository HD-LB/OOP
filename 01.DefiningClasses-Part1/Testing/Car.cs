using System;

namespace Testing
{
   public class Car
   {
      //public const int NumOfWheels = 4; // const has to be defined
      public readonly int NumOfWheels; //readonly doesn't have to be defined

      public string Brand;

      public string Color;

      public Engine Engine;

      //constructor --> ctor + Tab Tab
      public Car()
      {
         this.NumOfWheels = 4;
      }
   }
}
