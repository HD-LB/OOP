//•Define abstract class Human with a first name and a last name.Define a new class Student which is derived from Human and has a new field – grade.Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per hour by the worker.Define the proper constructors and properties for this hierarchy.
//•Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//•Initialize a list of 10 workers and sort them by money per hour in descending order.
//•Merge the lists and sort them by first name and last name.


namespace _02.StudentsAndWorkers
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public class StudentsAndWorkersMain
   {
      public const int workingDays = 5;

      static void Main()
      {
         List<Student> students = new List<Student>();
         students.Add(new Student("Ivan", "Ivanov", 7));
         students.Add(new Student("Pesho", "Peshev", 8));
         students.Add(new Student("Gosho", "Goshev", 10));
         students.Add(new Student("Todor", "Todorov", 12));
         students.Add(new Student("Sotir", "Sotirov", 3));
         students.Add(new Student("Bogdan", "Bogdanov", 5));
         students.Add(new Student("Krum", "Krumov", 10));
         students.Add(new Student("Milen", "Milenov", 6));
         students.Add(new Student("Velko", "Velkov", 6));
         students.Add(new Student("Nikola", "Nikolov", 7));

         var sortedStudents = students.OrderBy(s => s.Grade)
                                      .GroupBy(s => s.Grade)
                                      .ToList();

         foreach (var group in sortedStudents)
         {
            Console.WriteLine("grade {0}: ", group.Key);
            foreach (var st in group)
            {
               Console.WriteLine(st.ToString());
            }
         }
         Console.WriteLine();

         Console.WriteLine();


         List<Worker> workers = new List<Worker>();
         workers.Add(new Worker("Alexander", "Alexandrov", 993, 12));
         workers.Add(new Worker("Boris", "Borisov", 809, 12));
         workers.Add(new Worker("Venelin", "Vangelov", 365, 8));
         workers.Add(new Worker("Genadi", "Genadiev", 678, 10));
         workers.Add(new Worker("Dimo", "Dimov", 345, 7));
         workers.Add(new Worker("Evtim", "Evtimov", 567, 10));
         workers.Add(new Worker("Zdravko", "Zdravkov", 543, 12));
         workers.Add(new Worker("Ivan", "Ivanov", 987, 11));
         workers.Add(new Worker("Katerina", "Petrova", 975, 12));
         workers.Add(new Worker("Anton", "Andonov", 753, 8));

         var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour(workingDays)).ToList();

         foreach (var worker in sortedWorkers)
         {
            Console.WriteLine(worker.ToString() + "Money per hour = {0:F2}", worker.MoneyPerHour(workingDays));
         }
         Console.WriteLine();


         var people = new List<Human>();
         people.AddRange(students);
         people.AddRange(workers);

         var sortedPeople =
            from human in people
            orderby human.LastName
            orderby human.FirstName
            select human;

         foreach (var human in sortedPeople)
         {
            Console.WriteLine(human.ToString());
         }
         Console.WriteLine();
      }
   }
}
