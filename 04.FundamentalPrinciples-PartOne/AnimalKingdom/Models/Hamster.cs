namespace AnimalKingdom.Models
{
   using System;
   
   public class Hamster : Mammal
   {
      public Hamster()
      {
         base.Name = "Gosho";
      }

      public void ProvokeHappiness()
      {
         Console.WriteLine("Your human is happy!");
      }
   }
}
