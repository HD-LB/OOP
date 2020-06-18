//•Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//•Use LINQ query operators.


namespace _03.FirstBeforeLast
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;


   public static class FirstBeforeLastMain
   {
      static void Main()
      {
         Student[] students = new Student[]
            {

                 new Student("Ivan", "Petrov", 32),
                 new Student("George", "Ivanov", 22),
                 new Student("Stamat", "Angelov", 19),
                 new Student("Pesho", "Todorov", 23),
                 new Student("Gosho", "Andreev", 25),
                 new Student("Ivan", "Kolev", 26)
            };

         //Using Lambda Expretions
         var result = students
            .Where(s => s.FirstName.CompareTo(s.LastName) < 0)
            .Select(s => s);

         foreach (Student student in result)
         {
            Console.WriteLine(student);
         }


         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine();


         //Using LINQ
         var output =
            from student in students
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;

         foreach (Student student in output)
         {
            Console.WriteLine(student);
         }


      }
   }
}
