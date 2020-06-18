namespace CatSystem
{
   using System;

   public static class Printer
   {
      public static void PrintCat(Cat cat)
      {
         Console.WriteLine(cat.Name + " " + cat.Age);
      }
   }
}
