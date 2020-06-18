namespace _02.IEnumerableExtensions.Extensions
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public static class MinExtension
   {
      public static T Min<T>(this IEnumerable<T> enumeration) where T : IConvertible, IComparable
      {
         dynamic minValue = enumeration.First();
         foreach (var item in enumeration)
         {
            if (item.CompareTo(minValue) < 0)
            {
               minValue = item;
            }
         }
         return minValue;
      }
   }
}
