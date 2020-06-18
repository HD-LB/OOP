namespace AnimalKingdom.Models
{
  
   using System;
   using Interfaces;

   public class Monster : IAnimal
   {
      public int Age
      {
         get
         {
            throw new NotImplementedException();
         }
      }

      public Heart Heart
      {
         get
         {
            throw new NotImplementedException();
         }
      }

      public bool IsAlive
      {
         get
         {
            throw new NotImplementedException();
         }
      }

      public void Die()
      {
         throw new NotImplementedException();
      }

      public void Eat(IEdable food)
      {
         throw new NotImplementedException();
      }
   }
}
