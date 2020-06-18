//•Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace _06.DevisibleBy7And3
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public class DevisibleBy7And3Main
   {
      private static Random random = new Random();

      public static void Main()
      {
         int[] numbers = new int[100];
         for (int i = 0; i < numbers.Length; i++)
         {
            numbers[i] = i;
         }

         Console.WriteLine("Using Lambda: ");
         var numbersUsingLambda = numbers.Where(x => (x % 3 == 0 && x % 7 == 0));
         foreach (var number in numbersUsingLambda)
         {
            Console.WriteLine(number);
         }

         Console.WriteLine();

         Console.WriteLine("Using LINQ: ");
         var numbersUsingLINQ = from number in numbers
                                where (number % 3 == 0 && number % 7 == 0)
                                select number;
         foreach (var number in numbersUsingLINQ)
         {
            Console.WriteLine(number);
         }

         Console.WriteLine();

         //Option wit Random

         List<int> numberList = new List<int>();
         AddRandomNumber(numberList, 15);

         Console.WriteLine("Initial Random Numbers are: ");
         foreach (var number in numberList)
         {
            Console.Write(number + " ");
         }

         Console.WriteLine();

         Console.WriteLine("The Random Numbers using Lambda are: ");
         var randomUmbersLambda = numberList.Where(x => (x % 3 == 0 && x % 7 == 0));
         foreach (var item in randomUmbersLambda)
         {
            Console.Write(item + " ");
         }

         Console.WriteLine();

         Console.WriteLine("The Random Numbers using LINQ are: ");
         var randomNUmbersLINQ = from number in numberList
                                 where (number % 3 == 0 && number % 7 == 0)
                                 select number;
         foreach (var item in randomNUmbersLINQ)
         {
            Console.Write(item + " ");
         }
      }

      private static void AddRandomNumber(List<int> numberList,  int count)
      {
         for (int i = 0; i < count; i++)
         {
            numberList.Add(random.Next(1, 101));
         }
      }
   }
}
