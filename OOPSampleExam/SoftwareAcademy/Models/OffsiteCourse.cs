namespace SoftwareAcademy.Models
{
    using System;
    using SoftwareAcademy.Interfaces;


    public class OffsiteCourse : Course, ICourse, IOffsiteCourse
    {
        //Constructor
        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        //Proparties
        public string Town { get; set; }

        public override string ToString()
        {
            return string.Format("{0}; Town={1}", base.ToString(), this.Town);
        }
    }
}
