namespace AnimalKingdom.Interfaces
{
   using System;
   
   public interface IPet 
   {
      string Owner { get; }

      decimal Price { get; }

      void ProvokeHappiness();
   }
}
