//•Write a program to return the string with maximum length from an array of strings.
//•Use LINQ.


namespace _17.LongestString
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public class LongestString
   {
      static void Main()
      {
         string[] array = new string[] { "Andromeda", "Cameloperdalis", "Centaurus", " Eridanus", "Horologium", "Monoceros" };

         var longestString = (from str in array
                              orderby str.Length descending
                              select str).FirstOrDefault();

         Console.WriteLine(longestString);
      }
   }
}
