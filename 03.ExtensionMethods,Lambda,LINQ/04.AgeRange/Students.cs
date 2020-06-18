namespace _04.AgeRange
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public class Students
   {
      public Students(string firstName, string lastName, int age)
      {
         this.FirstName = firstName;
         this.LastName = lastName;
         this.Age = age;
      }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public int Age { get; set; }

      
      public override string ToString()
      {
         return string.Format("{0} {1}", this.FirstName, this.LastName);

      }
   }
}

