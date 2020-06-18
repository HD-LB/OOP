namespace _02.StudentsAndWorkers
{
   using System;

   public class Student : Human
   {
      private int grade;
      
      public Student(string firstName, string lastName, int grade) 
         : base(firstName, lastName)
      {
         this.Grade = grade;
      }

      public int Grade
      {
         get { return this.grade; }
         set
         {
            if (value < 1 || value > 13)
            {
               throw new ArgumentException("The grade shoul be between 1 and 12.");
            }
            this.grade = value;
         }

      }
   }
}
