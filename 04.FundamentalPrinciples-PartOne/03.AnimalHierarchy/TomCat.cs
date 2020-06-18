namespace _03.AnimalHierarchy
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public class TomCat : Cat
   {
      public TomCat(int age, string name, Gender gender) 
         : base(age, name, Gender.Male)
      {
      }
   }
}
