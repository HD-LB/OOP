namespace LectureIvo.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MainStart
    {
        public static void Main()
        {
            var text = "Pesho Gosho Ivan";
            var wordCount = text.CountWords();

            Console.WriteLine(wordCount);


            //Extention Methods
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.IncreaseWithNumber(5);

            var student = new Student { FirstName = "Pesho", LastName = "Goshov" };


            //Funk
            Func<string, string, Student> studentGenerator = (x, y) => new Student { FirstName = x, LastName = y };

            var someStudent = studentGenerator("Pesho", "Ivanov");
            Console.WriteLine(someStudent.FirstName);


            //LINQ
            var anotherList = new List<int> { 1, 2, 6, 3, 8, 10 };

            var lessThanFive =
               from n in anotherList
               where n < 5 && n != 3
               //orderby n;
               select n + 100;

            foreach (var number in lessThanFive)
            {
                Console.WriteLine(number);
            }


            //Anonymous
            var studentList = new List<Student>
         {
            new Student { FirstName = "Ivan", LastName = "Ivanov", Mark = 2},
            new Student { FirstName = "Pesho", LastName = "Goshov", Mark = 4},
            new Student { FirstName = "Dragan", LastName = "Draganov", Mark = 3},
            new Student { FirstName = "George", LastName = "Georgiev", Mark = 2}
         };

            var passedStudents =
               from thisStudent in studentList
               where thisStudent.Mark > 2
               orderby thisStudent.LastName
               select thisStudent.FirstName + " " + thisStudent.LastName;

            foreach (var thisStudent in passedStudents)
            {
                Console.WriteLine(thisStudent);
            }

            var lastNames = studentList.Select(st => new { Mark = st.Mark, FullName = st.FirstName + " " + st.LastName });

            var averageMark = studentList.Average(st => st.Mark);

            //
            var textSharp = "Hi, I am C Sharp C Sharp C Sharp.";
            var search = "sharp";

            var result = text.Split(' ')
                             .Where(w => w.ToLower() == search.ToLower())
                             .Count();

            Console.WriteLine(result);



        }
    }
}
