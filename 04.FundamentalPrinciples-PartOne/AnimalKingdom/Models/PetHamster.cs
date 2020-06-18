namespace AnimalKingdom.Models
{
   using System;
   using Interfaces;

   public class PetHamster : Hamster, IPet
   {
      public PetHamster()
      {
         this.Owner = "Pesho";
      }

      public string Owner { get; private set; }
     

      public decimal Price
      {
         get
         {
            throw new NotImplementedException();
         }
      }

      public void ProvokeHappiness()
      {
         Console.WriteLine("Your owner {0} is happy!", this.Owner);
      }
   }
}
