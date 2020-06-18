namespace Lambda
{
   
   using System;   
   using System.Collections.Generic;
   using System.Linq;
   using MOdels;

   class StudentSystem
   {
      static void Main()
      {
         List<Student> students = GetStudents();

       students.FindAll(st => st.Gender == GenderType.Male)
               .FindAll(st => st.Age > 20)
               .ForEach(Console.WriteLine);

         //students.ForEach(Console.WriteLine);

         foreach (var st in students)
         {
            Console.WriteLine(st);
         }

         //   string input = "1 2 3 4 5 6 7 8";
         //   input.Split(' ').ForEach(x => int.Parse(x)).ForEach(Console.WriteLine);
         //}
      }



      private static List<Student> GetStudents()
      {
         return new List<Student>()
         {
            new Student
            {
               Id = 1,
               FirstName = "Pesho",
               LastName  = "Peshev",
               DateOfBirth = new DateTime(1985, 5, 5),
               Gender = GenderType.Male,
               Grade = new List<Grade> { new Grade(5), new Grade(3), new Grade(2)}
            },

            new Student
            {
               Id = 2,
               FirstName = "Ivan",
               LastName  = "Ivanov",
               DateOfBirth = new DateTime(1995, 5, 15),
               Gender = GenderType.Male,
               Grade = new List<Grade> { new Grade(2), new Grade(2), new Grade(2)}
            },
            new Student
            {
               Id = 3,
               FirstName = "Maria",
               LastName  = "Stankova",
               DateOfBirth = new DateTime(1999, 5, 15),
               Gender = GenderType.Male,
               Grade = new List<Grade> { new Grade(2)}
            },
            new Student
            {
               Id = 4,
               FirstName = "Elka",
               LastName  = "Milkova",
               DateOfBirth = new DateTime(1999, 1, 25),
               Gender = GenderType.Male,
               Grade = new List<Grade> { new Grade(2), new Grade(2)}
            },
            new Student
            {
               Id = 5,
               FirstName = "Elka",
               LastName  = "Stankova",
               DateOfBirth = new DateTime(2000, 8, 16),
               Gender = GenderType.Male,
               Grade = new List<Grade> { new Grade(6), new Grade(6), new Grade(6)}
            }
         };
      }
   }
}
