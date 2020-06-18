namespace Lambda.MOdels
{
   using System;
   using System.Collections;
   using System.Collections.Generic;

   class Student
   {
      public int Id { get; set; }

      public string FirstName { get; set; }

      public string LastName { get; set; }

      public GenderType Gender { get; set; }

      public DateTime DateOfBirth { get; set; }

      public IEnumerable<Grade> Grade { get; set; }

      public int Age
      {
         get
         {
            return (DateTime.Now - DateOfBirth).Days / 365;
         }
         
      }

      public override string ToString()
      {
         return base.ToString();
      }
   }
}
