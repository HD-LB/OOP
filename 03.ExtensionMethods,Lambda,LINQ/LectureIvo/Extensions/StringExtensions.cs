namespace LectureIvo.Extensions
{
   using System;

   public static class StringExtensions
   {
      //Extension Method --> always has to be static
      public static int CountWords(this string input)
      {
         var words = input.Split(' ');
         return words.Length;
      }
   }
}
