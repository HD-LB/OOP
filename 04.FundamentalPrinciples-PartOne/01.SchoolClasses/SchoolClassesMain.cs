//•We are given a school.In the school there are classes of students.Each class has a set of teachers.Each teacher teaches, a set of disciplines. Students have a name and unique class number. Classes have unique text identifier.Teachers have a name.Disciplines have a name, number of lectures and number of exercises.Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
//•Your task is to identify the classes(in terms of OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.


namespace _01.SchoolClasses
{
   using System; 
   using System.Collections.Generic;
   using Models;

   public class SchoolClassesMain
   {
      static void Main()
      {
         Student studentPetronka = new Student("Petronka", "Ivanova", 1);
         Student studentKaramfilka = new Student("Karamfilka", "Georgoeva", 2);
         Student studentIvan = new Student("Ivan", "Ivanov", 3);

         List<Student> studentsInClassA = new List<Student>();
         studentsInClassA.Add(studentPetronka);
         studentsInClassA.Add(studentKaramfilka);
         studentsInClassA.Add(studentIvan);

         foreach (var st in studentsInClassA)
         {
            Console.WriteLine(st.ToString());
         }
         Console.WriteLine();

         Discipline math = new Discipline("Math", 10, 10);
         Discipline biology = new Discipline("Biology", 14, 14);
         Discipline physics = new Discipline("Physics", 12, 12);

         Teacher ivoHristov = new Teacher("Ivo", "Hristov");
         ivoHristov.AddDiscipline(math);
         ivoHristov.AddDiscipline(physics);
         

         Teacher mariaPetrova = new Teacher("Maria", "Petrova");
         mariaPetrova.AddDiscipline(biology);

         Class classA = new Class("10B");
         classA.AddTeacher(ivoHristov);

         classA.AddComment("We are Class 10B.");
         

      }
   }
}
