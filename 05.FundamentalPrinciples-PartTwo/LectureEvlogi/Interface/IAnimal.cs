namespace LectureEvlogi.Animals
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public interface IAnimal
   {
      string Name { get; }

      string Speak();
   }
}
