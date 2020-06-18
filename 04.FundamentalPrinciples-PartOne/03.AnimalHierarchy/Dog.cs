namespace _03.AnimalHierarchy
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public class Dog : Animal
   {
      public Dog(int age, string name, Gender gender) 
         : base(age, name, gender)
      {
      }

      public override string MySound
      {
         get
         {
            return "Baw! Baw! Baw!";
         }
      }
   }
}
