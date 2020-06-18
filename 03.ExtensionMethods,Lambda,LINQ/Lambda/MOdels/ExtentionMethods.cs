namespace Lambda.MOdels
{
   using System;
   using System.Collections;
   using System.Collections.Generic;

   public static class ExtentionMethods
   {
      public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
      {
         IList<T> newCollection = new List<T>();
         foreach (T item in collection)
         {
            action(item);
         }         
      }

      public static IEnumerable<TResult> ForEach<T1, TResult>(this IEnumerable<T1> collection, Func<T1, TResult> func)
      {
         List<TResult> result = new List<TResult>();
                  
         foreach (T1 item in collection)
         {
            result.Add(func(item));
         }

         return result;
      }


      public static IEnumerable<T> FindAll<T>(this IEnumerable<T> collection, Func<T, bool> func)
      {
         List<T> result = new List<T>();

         foreach (T item in collection)
         {
            if(func(item))
            {
               result.Add(item);
            }
         }

         return result;
      }
   }
}
