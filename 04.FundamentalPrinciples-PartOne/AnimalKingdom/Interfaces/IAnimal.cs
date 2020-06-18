namespace AnimalKingdom.Interfaces
{
   
   using System;
   using Models;

   public interface IAnimal
   {
      bool IsAlive { get;  }
      Heart Heart { get; }
      int Age { get; }



      //Method
      void Eat(IEdable food);
      void Die();
   }
}
