namespace AnimalKingdom.Models
{
   
   using System;
   using Interfaces;

   public class Dolphin : Mammal, IPet
   {
      public string Owner
      {
         get
         {
            throw new NotImplementedException();
         }
      }

      public decimal Price
      {
         get
         {
            throw new NotImplementedException();
         }
      }

      public void ProvokeHappiness()
      {
         throw new NotImplementedException();
      }

      public override void Move()
      {
         this.FlapTail();

      }

      private void FlapTail()
      {
         throw new NotImplementedException();
      }
   }
}
