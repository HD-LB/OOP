namespace LectureEvlogi.Models
{
   using System;

   public class Student : Person
   {
        //Constructor
      public Student(string name, string eMail, int studentID)
          : base (name, eMail)
      {
         this.StudentID = studentID;
      }

        //Proparties
      public int StudentID { get; private set; }
   }
}
