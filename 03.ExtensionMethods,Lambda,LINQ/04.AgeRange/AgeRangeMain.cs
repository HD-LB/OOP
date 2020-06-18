namespace _04.AgeRange
{
   using System;
   using System.Collections.Generic;
   using System.Linq;


   public static class AgeRangeMain
   {
      static void Main()
      {
         

         List<Students> students = new List<Students>();
         students.Add(new Students("Ivan", "Ivanov", 22));
         students.Add(new Students("Petar", "Marinov", 31));
         students.Add(new Students("Maria", "Ivanova", 19));
         students.Add(new Students("Lili", "Hristova", 20));
         students.Add(new Students("Ivan", "Antonov", 26));
         students.Add(new Students("George", "Stoychev", 27));
         students.Add(new Students("Marian", "Georgiev", 28));
         students.Add(new Students("Aneta", "Petrova", 29));
         students.Add(new Students("Zdravko", "Velichkov", 30));
         students.Add(new Students("Pesho", "Stamatov", 31));
         students.Add(new Students("Stamat", "Peshev", 32));


         Console.WriteLine("The initial list if students: ");
         PrintStudents(students);


         //Console.WriteLine("Initial list:");
         //foreach (var st in students)
         //{
         //   Console.WriteLine(st);
         //}

         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine();


         //First Name and Last Name of Students between 18 and 24
         var selectedByAge =
            from student in students
            where student.Age >= 18 && student.Age <= 24
            select student;

         Console.WriteLine("Students between the Age 18 and 24 are: ");
         PrintStudents(selectedByAge);
                  
      }

      public static void PrintStudents(IEnumerable<Students> students)
      {
         foreach (var st in students)
         {
            Console.WriteLine(st.FirstName + " " + st.LastName);
         }
         Console.WriteLine();
      }

   }
}

