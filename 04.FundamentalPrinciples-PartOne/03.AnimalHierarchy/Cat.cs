namespace _03.AnimalHierarchy
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public class Cat : Animal
   {
      public Cat(int age, string name, Gender gender) 
         : base(age, name, gender)
      {
      }

      public override string MySound
      {
         get
         {
            return "Meow! Meow! Meaow!";
         }
      }
   }
}
