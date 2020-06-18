//•Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty.Use an enumeration for the specialties, universities and faculties.
//•Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentClass
{
    class StudentClassMain
    {
        static void Main()
        {
            Student studentGosho = new Student("Georgi", "Georgiev", "Goshov", 1234545, "Vitosha 12", "08991234556", "gosho@dir.bg", 4, University.Technical, Faculty.Electronics, Specialty.Engineer);
            Student studentPesho = new Student("Pesho", "Peshev", "Dimov", 345678, "Dobdukov 14", "0898345678", "pesho@dir.bg", 3, University.UNSS, Faculty.Biology, Specialty.Doctor);

            Console.WriteLine(studentGosho);
            Console.WriteLine(studentPesho);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(studentGosho.CompareTo(studentPesho));
        }
    }
}
