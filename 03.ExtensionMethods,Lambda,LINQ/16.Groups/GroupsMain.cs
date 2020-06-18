//•Create a class Group with properties GroupNumber and DepartmentName.
//•Introduce a property GroupNumber in the Student class.
//•Extract all students from "Mathematics" department.
//•Use the Join operator.


namespace _16.Groups
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using _09.StudentGroups; //Add a Reference


   public class GroupsMain
   {
      static void Main()
      {
         List<Student> students = new List<Student>();


         students
            .Add(new Student("Angel", "Georgiev", "896506", "042 456 321", "a.georgiev@dir.bg", new List<int> { 4, 6 }, 1));
         students
            .Add(new Student("Gosho", "Dinev", "789607", "02 456 322", "g.dinev@abv.bg", new List<int> { 4, 3 }, 1));
         students
            .Add(new Student("Ani", "Petrova", "7896106", "0887 456 323", "a.petrova@abv.bg", new List<int> { 4, 3, 5 }, 1));
         students
            .Add(new Student("Pesho", "Ivanov", "896205", "056 456 324", "p.ivanov@abv.bg", new List<int> { 4, 6 }, 2));
         students
             .Add(new Student("Dragan", "Georgiev", "654106", "02 456 325", "d.georgiev@adir.bg", new List<int> { 4, 4, 3, 5, 3 }, 2));
         students
             .Add(new Student("Ivan", "Peevski", "964107", "02 456 333", "i.peevski@abv.bg", new List<int> { 6 }, 2));
         students
            .Add(new Student("Peter", "Dimitrov", "654108", "0887 456 334", "p.dimitrov@abv.bg", new List<int> { 4, 6, 3, 3, 2 }, 3));
         students
             .Add(new Student("Rosen", "Popov", "789109", "0887 456 335", "r.popov@abv.bg", new List<int> { 4 }, 3));
         students
            .Add(new Student("Desi", "Georgieva", "954206", "0887 456 316", "d.georgieva@dir.bg", new List<int> { 6, 6, 5, 4, 6, 4 }, 4));
         students
            .Add(new Student("Maria", "Mileva", "652105", "02 456 356", "m.mileva@abv.bg", new List<int> { 6, 6, 6, }, 4));


         Group group = new Group(2, "Mathematics");
         List<Group> groups = new List<Group>() { group };

         var mathStudents = from student in students
                            join gr in groups on student.GroupNumber equals gr.GroupNumber
                            select student;

         foreach (Student student in students)
         {
            Console.WriteLine(student);
         }
      }
   }
}
