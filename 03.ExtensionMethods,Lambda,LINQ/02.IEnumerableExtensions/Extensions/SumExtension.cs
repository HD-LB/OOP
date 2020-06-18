namespace _02.IEnumerableExtensions.Extensions
{
   using System;
   using System.Collections.Generic;

   public static class SumExtension
   {
      public static T Sum<T>(this IEnumerable<T> enumeration)
      {
         dynamic sum = 0;
         foreach (var item in enumeration)
         {
            sum += item;
         }
         return sum;
      }
   }
}
