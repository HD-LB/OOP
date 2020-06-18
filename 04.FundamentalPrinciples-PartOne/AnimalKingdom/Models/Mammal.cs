namespace AnimalKingdom.Models
{
   using System;
   
   public class Mammal : Animal
   {
      public Mammal():
         base(0)
      {

      }

      public string Name { get; set; }

      public virtual void Move()
      {

      }
      
   }
}
