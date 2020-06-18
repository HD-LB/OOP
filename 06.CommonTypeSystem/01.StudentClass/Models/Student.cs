namespace _01.StudentClass
{

    using System;
    using System.Text;


    public class Student : ICloneable, IComparable<Student>
    {     

        //Constructors
        public Student(string firstName, string middleName, string lastName, int sSN)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = sSN;
        }

        public Student(string firstName, string middleName, string lastName, int sSN, string permanentAddress, string phoneNumber,string eMail, int course, University universityName, Faculty facultyName, Specialty specialtyName)
            :this(firstName, middleName, lastName, sSN)
        {
            this.PermanentAddress = permanentAddress;
            this.PhoneNumber = phoneNumber;
            this.EMail = eMail;
            this.Course = course;
            this.University = universityName;
            this.Faculty = facultyName;
            this.Specialty = specialtyName;
        }

        //Proparties
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string PermanentAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public int Course { get; set; }

        public University University { get; set; }
        public Faculty Faculty { get; set; }
        public Specialty Specialty { get; set; }

        //Methods To Override
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Student:");
            sb.AppendLine(String.Format("Name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            sb.AppendLine(String.Format("SSN: {0}", this.SSN));

            if (this.PermanentAddress != null)
            {
                sb.AppendLine(String.Format("Address: {0}", this.PermanentAddress));
            }
            if (this.PhoneNumber != null)
            {
                sb.AppendLine(String.Format("Phone Number: {0}", this.PhoneNumber));
            }
            if (this.EMail != null)
            {
                sb.AppendLine(String.Format("E-Mail: {0}", this.EMail));
            }
            if (this.Course != 0)
            {
                sb.AppendLine(String.Format("Course: {0}", this.Course));
            }
            if (this.University != University.None)
            {
                sb.AppendLine(String.Format("University: {0}", this.University));
            }
            if (this.Faculty != Faculty.None)
            {
                sb.AppendLine(String.Format("Faculty: {0}", this.Faculty));
            }
            if (this.Specialty != Specialty.None)
            {
                sb.AppendLine(String.Format("Specialty: {0}", this.Specialty));
            }
            
            return sb.ToString();
        }


        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }
            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }
            if (!Object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }
            if (!Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }
            return true;
        }


        public static bool operator == (Student firstStudent, Student secondStudent)
        {
            return firstStudent.Equals(secondStudent);
        }
        public static bool operator != (Student firstStudent, Student secondStudent)
        {
            return !firstStudent.Equals(secondStudent);
        }


        public override int GetHashCode()
        {
            int hashCode = this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode();
            return hashCode;
        }


        public object Clone()
        {
            Student originalStudent = this;
            Student clonedStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress, this.PhoneNumber, this.EMail, this.Course, this.University, this.Faculty, this.Specialty);
            return clonedStudent;
        }



        public int CompareTo(Student anotherStudent)
        {
            if (this.FirstName != anotherStudent.FirstName)
            {
                return (string.Compare(this.FirstName, anotherStudent.FirstName));
            }
            if (this.MiddleName != anotherStudent.MiddleName)
            {
                return (string.Compare(this.MiddleName, anotherStudent.MiddleName));
            }
            if (this.LastName != anotherStudent.LastName)
            {
                return (string.Compare(this.LastName, anotherStudent.LastName));
            }
            if (this.SSN != anotherStudent.SSN)
            {
                return (int)(this.SSN - anotherStudent.SSN);
            }
            return 0;
        }
    }
}
