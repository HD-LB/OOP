namespace LINQ
{
   using System;
   using System.Linq;

   class Program
   {
      static void Main()
      {
         string[] towns = { "Sofia", "Varna", "Pleven", "Ruse", "Bourgas" };

         var townPairs =
            from town1 in towns
            from town2 in towns
            where town1 != town2
            select new { T1 = town1, T2 = town2 };

         foreach (var townPair in townPairs)
         {
            Console.WriteLine(townPair);

         }
      }
   }
}
