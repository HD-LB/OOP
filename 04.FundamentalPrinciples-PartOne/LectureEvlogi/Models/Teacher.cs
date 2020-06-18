namespace LectureEvlogi.Models
{
  
   using System;
   using Interfaces;


   public class Teacher : Person, IPerson
   {
      private static string name;

        //Constructor
      public Teacher(string Name, string eMail, string subject)
         : base (name, eMail)
      {
         this.Subject = subject;
      }

        //Proparty
      public string Subject { get; set; }
   }
}
