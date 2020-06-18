using System;

namespace Practice
{
   class AnimalStore
   {
      static void Main()
      {
         var firstHorse = new Horse();

         firstHorse.name = "Ivan";
         firstHorse.SayMyName();

         var secondHorse = new Horse() { name = "Pesho" };
         secondHorse.SayMyName();       
      
      }
   }
}
