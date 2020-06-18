namespace _01.StringBuilder.Substring.Models
{
   using System;
   using System.Text;

   public static class StringBuilderExtentions
   {
      public static StringBuilder Substring(this StringBuilder text, int index, int lenght)
      {
         StringBuilder result = new StringBuilder();
         for (int i = index, z = 0; z < lenght; i++, z++)
         {
            result.Append(text[i]);
         }
         return result;
      }
   }
}
