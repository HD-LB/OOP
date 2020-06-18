namespace AnimalKingdom.Models
{   
   using System;
   using Interfaces;

   public class Animal : IAnimal
   {
      //Constructor
      public Animal()
      {
         this.IsAlive = true;
      }

      public Animal( int age)
         : this()
      {
         this.Age = age;
      }

      //Proparty
      public bool IsAlive { get; set; }

      public Heart Heart { get; private set; }

      public int Age { get; private set; }



      //Method
      public void Eat(IEdable food)
      {

      }

      public void Die()
      {
         this.IsAlive = false;
      }
   }
}
