namespace _01.SchoolClasses
{

    using System;
    using System.Collections.Generic;
    using System.Text;

    using Interface;
    using Models;


    public class Teacher : Person, IComment
    {
        private List<Discipline> taechersDesciplines;

        public Teacher(string firstName, string lastName, params Discipline[] discipline)
           : base(firstName, lastName)
        {
            this.taechersDesciplines = new List<Discipline>();
            this.taechersDesciplines.AddRange(discipline);
        }

        public List<Discipline> TeachersDesciplines
        {
            get
            {
                return new List<Discipline>(this.taechersDesciplines);
            }
        }


        public void AddDiscipline(Discipline discipline)
        {
            this.taechersDesciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.taechersDesciplines.Remove(discipline);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Taecher's Name: " + base.FirstName + " " + base.LastName);
            sb.AppendLine("Teacher's Discipline: ");
            sb.AppendLine(string.Join(", ", TeachersDesciplines));

            return sb.ToString();
        }
    }
}
