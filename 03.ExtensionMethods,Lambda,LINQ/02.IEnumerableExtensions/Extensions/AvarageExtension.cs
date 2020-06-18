namespace _02.IEnumerableExtensions.Extensions
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public static class AvarageExtension
   {
      public static T Avg<T>(this IEnumerable<T> enumeration)
      {
         dynamic avg = 0;
         foreach (var item in enumeration)
         {
            avg += item;
         }
         return avg / enumeration.Count();
      }
   }
}
