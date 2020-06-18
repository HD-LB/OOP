namespace CatSystem
{
   using System;

   public class CatSystemStart
   {
      static void Main()
      {
         //var peshoOwner = new Owner("Pesho", "Ivanov");

         //var goshoOwner = new Owner("Gosho", "Petrov");

         //var cat = new Cat(CatColor.Mixed);
         //var anotherCat = new Cat(CatColor.Mixed);
         //var yetAnotherCat = new Cat(CatColor.Mixed);

         //peshoOwner.AddCat(cat, "Maca");
         //peshoOwner.AddCat(anotherCat, "Pisana");

         //Console.WriteLine(peshoOwner.AllCats);

         //Console.WriteLine(Cat.WhatDoesTheCatSay()); // static Method

         ////cat.Owner = peshoOwner;

         ////peshoOwner.IncreaseAge(); //calling the Method

         ////Console.WriteLine(peshoOwner.Age);

         //Printer.PrintCat(yetAnotherCat); //using a static Class


         //Generics
         var myList = new GenericList<int>();

         myList.Add(1);
         myList.Add(2);


         GenericList<int> list = new GenericList<int>();

         list.Add(1);

         Console.WriteLine(list[0]);




         StringCouple myStrings = new StringCouple();

         myStrings.Add("Peshp", "Peshev");
         myStrings.Add("Gosho", "Goschev");


      }
   }
}
