namespace _18.GroupdByGroupNumber
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public class Student
   {
      public Student(string firstName, string lastName, int groupNumber)
      {
         this.FirstName = firstName;
         this.LastName = lastName;
         this.GroupNumber = groupNumber;
      }

      public string FirstName { get; set; }

      public string LastName { get; set; }

      public int GroupNumber { get; set; }

      public override string ToString()
      {
         return string.Format("{0} {1}", this.FirstName, this.LastName);
      }
   }
}
