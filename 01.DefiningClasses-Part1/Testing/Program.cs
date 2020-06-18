//https://my.telerikacademy.com/Courses/LectureResources/Video/6031/Видео-11-март-2015-Евлоги

using System;

namespace Testing
{
   class Program
   {
      static void Main()
      {
         Dog myDog = new Dog();
         myDog.Name = "Sharo";
         Console.WriteLine(Dog.NumOfLegs); //because NumOfLegs is static

         Console.WriteLine(myDog.Name);


         var myCar = new Car()
         {
            Brand = "BMW",
            Color = "black",
            Engine = new Engine {HorsePowers = 300} //fields
         };

         Console.WriteLine(myCar.Brand);


         //another Option

         Engine myEngine = new Engine();
         myEngine.HorsePowers = 300;
         myCar.Engine = myEngine;
         Console.WriteLine(myCar.Engine.HorsePowers);



         Dog firstDog = new Dog(/*"Pesho", "Pincher"*/);
         firstDog.name = "Pesho";
         firstDog.breed = "Pincher";

         Dog secondDog = new Dog(/*"Stamat", "German shephard"*/);
         
           

         Console.WriteLine(firstDog.name);
         Console.WriteLine(secondDog.name);
      }
   }
}
