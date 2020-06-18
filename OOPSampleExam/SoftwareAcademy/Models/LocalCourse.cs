namespace SoftwareAcademy.Models
{
    using System;
    using SoftwareAcademy.Interfaces;
   

    public class LocalCourse : Course, ICourse, ILocalCourse
    {
        //Constructor
        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab; 
        }


        //Proparties
        public string Lab { get; set; }

        public override string ToString()
        {
            return string.Format("{0}; Lab={1}", base.ToString(), this.Lab);
        }

    }
}
