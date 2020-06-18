namespace SoftwareAcademy.Models
{
    using System;
    using System.Collections.Generic;

    using SoftwareAcademy.Interfaces;


    public abstract class Course : ICourse
    {
        //Fields 
        private ICollection<string> topics;

        //Constructor
        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
        }


        //Proparties
        public string Name { get; set; }

        public ITeacher Teacher { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            string result = string.Format("{0}: Name={1}", this.GetType().Name, this.Name);

            if (this.Teacher != null)
            {
                result += string.Format("; Teacher ={0}", this.Teacher.Name);
            }
            if (this.topics.Count > 0)
            {
                result += string.Format("; Topics=[{0}]", string.Join(", ", this.topics));
            }

            return result;
        }
    }
}
