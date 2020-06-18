namespace _19.GroupByGroupName
{
   using System;
   using System.Collections.Generic;
   using System.Linq;


   public class Student
   {
      public Student(string firstName, string lastName, string groupName)
      {
         this.FirstName = firstName;
         this.LastName = lastName;
         this.GroupName = groupName;
      }
      public string FirstName { get; set; }

      public string LastName { get; set; }

      public string GroupName { get; set; }

      public override string ToString()
      {
         return string.Format("{0} {1}", this.FirstName, this.LastName);
      }

   }
}
