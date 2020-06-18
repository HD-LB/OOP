namespace _03.AnimalHierarchy
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public class Kitten : Cat
   {
      public Kitten(int age, string name, Gender gender) 
         : base(age, name, Gender.Female)
      {
      }
   }
}
