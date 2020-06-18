//•Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
//•Rewrite the same with LINQ.


namespace _05.OrderStudents
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   
   public class OrderStudentsMain
   {
      static void Main()
      {
         List<Student> students = new List<Student>();
         students.Add(new Student("Ivan", "Ivanov", 22));
         students.Add(new Student("Petar", "Marinov", 31));
         students.Add(new Student("Maria", "Ivanova", 19));
         students.Add(new Student("Lili", "Hristova", 20));
         students.Add(new Student("Ivan", "Antonov", 26));
         students.Add(new Student("George", "Stoychev", 27));
         students.Add(new Student("Marian", "Georgiev", 28));
         students.Add(new Student("Aneta", "Petrova", 29));
         students.Add(new Student("Zdravko", "Velichkov", 30));
         students.Add(new Student("Pesho", "Stamatov", 31));
         students.Add(new Student("Stamat", "Peshev", 32));


         var sortetStudentsLambda = students.OrderByDescending(s => s.FirstName)
                                            .ThenBy(s => s.LastName);
         Console.WriteLine("The student's Names in decending order using Lambda are: ");
         PrintStudents(sortetStudentsLambda);

         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine();


         var sortedStudentsLINQ =
            from student in students
            orderby student.LastName
            descending
            orderby student.FirstName
            select student;

         Console.WriteLine("The student's Name in decending order using LINQ are: ");
         PrintStudents(sortedStudentsLINQ);
      }

      public static void PrintStudents(IOrderedEnumerable<Student> students)
      {
         foreach (var st in students)
         {
            Console.WriteLine(st.FirstName + " " + st.LastName);
         }
        
      }
   }
}
