namespace _01.StringBuilder.Substring
{
   using Models;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;

   //•Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.


   public static class Program
   {      
      static void Main()
      {
         StringBuilder str = new StringBuilder();
         str.Append("Some text for testing");
         StringBuilder final = str.Substring(1, 5);//Getting only index from 1 to 5 chars
         Console.WriteLine(final.ToString());

         //
         StringBuilder builder = new StringBuilder();
         builder.Append("Some text for testing");
         Console.WriteLine(builder.Substring(12, 3));
      }
   }
}
