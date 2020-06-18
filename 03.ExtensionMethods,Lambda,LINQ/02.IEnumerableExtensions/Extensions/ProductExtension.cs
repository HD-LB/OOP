namespace _02.IEnumerableExtensions.Extensions
{
   using System;
   using System.Collections.Generic;
   

   public static class ProductExtension
   {
      public static T Product<T>(this IEnumerable<T> enumeration)
      {
         dynamic product = 1;
         foreach (var item in enumeration)
         {
            product *= item;
         }
         return product;
      }
   }
}
