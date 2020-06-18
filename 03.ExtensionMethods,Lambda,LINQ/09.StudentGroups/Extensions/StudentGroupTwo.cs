namespace _09.StudentGroups
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public static class StudentGroupTwo
   {
      public static IEnumerable<Student> ExtensionSortedByGroup(this IEnumerable<Student> studentsGroup)
      {
         var sortedStudents =
            from st in studentsGroup
            where st.GroupNumber == 2
            select st;

         return sortedStudents;
      }
   }
}
