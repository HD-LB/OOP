namespace LectureIvo.Extensions
{
   using System;
   using System.Collections.Generic;

   public static class ListOfIntExtensions
   {
      public static void IncreaseWithNumber(this List<int> numbers, int numberToAdd)
      {
         for (int i = 0; i < numbers.Count; i++)
         {
            numbers[i] += numberToAdd;
         }                  
      }
   }
}
