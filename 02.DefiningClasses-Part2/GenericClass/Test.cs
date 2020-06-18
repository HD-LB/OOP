namespace GenericClass
{  
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using Models;

   public class Test
   {
      static void Main()
      {
         var list = new GenericList<int>(5);
         list.Add(5);
         list.Add(10);
         list.Add(20);


         list.Insert(1, 123);

         list.Add(0);
         list.Remove(4);

         Console.WriteLine(list);

         Console.WriteLine(list.Min());
         Console.WriteLine(list.Max());
      }
   }
}
