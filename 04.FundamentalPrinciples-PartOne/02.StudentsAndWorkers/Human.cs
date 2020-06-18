namespace _02.StudentsAndWorkers
{
   using System;

   public abstract class Human
   {
      //Fields
      private string firstName;
      private string lastName;

      //Cosntructor
      public Human(string firstName, string lastName)
      {
         this.FirstName = firstName;
         this.LastName = lastName;
      }

      //Proparties
      public string FirstName
      {
         get { return this.firstName; }
         set
         {
            if (string.IsNullOrEmpty(value))
            {
               throw new ArgumentException("Name cannot be empty.");
            }
            this.firstName = value;
         }
      }

      public string LastName
      {
         get { return this.lastName; }
         set
         {
            if (string.IsNullOrEmpty(value))
            {
               throw new ArgumentException("Name cannot be empty.");
            }
            this.lastName = value;
         }
      }

      public override string ToString()
      {
         return string.Format("{0} {1}", this.FirstName, this.LastName);
      }
   }
}
