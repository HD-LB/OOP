namespace _09.StudentGroups.Extensions
{
   using System;
   using System.Collections.Generic;
   using System.Linq;


   public static class StudentsTwoMarks
   {
      public static IEnumerable<Student> StudentTwoMarksEx(this IEnumerable<Student> students)
      {
         var sortedStudents = students.Where(s => s.Marks.Count == 2).ToList();

         return sortedStudents;
         
      }

   }
}
