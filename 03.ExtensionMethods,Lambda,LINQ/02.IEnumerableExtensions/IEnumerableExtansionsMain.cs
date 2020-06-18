//•Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

namespace _02.IEnumerableExtensions
{
   using System;  
   using System.Collections.Generic;
   using Extensions;

   public static class IEnumerableExtansionsMain
   {
      static void Main()
      {
         var test = new List<double> { 5.78, 6.32, 7, -95.3, 16, -1 };

         Console.WriteLine("Sum: " + test.Sum<double>());
         Console.WriteLine("Product: " + test.Product<double>());
         Console.WriteLine("Min: " + test.Min<double>());
         Console.WriteLine("Max: " + test.Max<double>());
         Console.WriteLine("Avarage: " + test.Avg<double>());

      }
   }
}
