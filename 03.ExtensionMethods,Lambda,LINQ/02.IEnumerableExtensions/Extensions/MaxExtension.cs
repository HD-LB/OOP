namespace _02.IEnumerableExtensions.Extensions
{
   using System;
   using System.Collections.Generic;
   using System.Linq;


   public static class MaxExtension
   {
      public static T Max<T>(this IEnumerable<T> enumeration) where T : IConvertible, IComparable
      {
         dynamic maxValue = enumeration.First();
         foreach (var item in enumeration)
         {
            if (item.CompareTo(maxValue) > 0)
            {
               maxValue = item;
            }
         }
         return maxValue;
      }
   }
}
