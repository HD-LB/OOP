namespace _01.SchoolClasses.Models
{
   using System;
   using System.Collections.Generic;
   using Interface;


   public class Student : Person, IComment
   {
      private int classNumber;

      public Student(string firstName, string lastName, int classNumber) 
         : base(firstName, lastName)
      {
         this.ClassNumber = classNumber;
      }

      public int ClassNumber
      {
         get { return this.classNumber; }
         set
         {
            if (value < 1)
            {
               throw new ArgumentException("The Class Number of the Student cannot be a negative number.");
            }
            this.classNumber = value;
         }         
      }
   }
}
