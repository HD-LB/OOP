namespace LectureEvlogi.Models
{  
   using System;
   using Interfaces;


   public class Person: IPerson
   {
        //Fields
      private string name;

        //Constructors
      public Person(string name, string eMail)
      {
         this.Name = name;
         this.EMail = eMail;
      }

        //Proparties
      public string EMail { get; private set; }

      
      public string Name
      {
         get
         {
            return this.name;
         }
         private set
         {
            if (string.IsNullOrEmpty(value))
            {
               throw new ArgumentException("Name should have some value");
            }

            this.name = value;
         }
      }

        //Mathods
      public void Walk()
      {
         Console.WriteLine("{0} is walking.", this.Name);
      }

      public Gender Gender
      {
         get
         {
            throw new NotImplementedException();
         }
      }

   }
}
