namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        //Fields
        private string firstName;
        private string lastName;


        //Constructors
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }


        //Properties

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The first name is not valid/too short.");
                }
                this.firstName = value;
            }
        }


        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The last name is not valid/too short.");
                }
                this.lastName = value;
            }
        }

        //Methods
        public List<string> comment;


        public void AddComment(string newComment)
        {
            var comment = new List<string>();
            comment.Add(newComment);
            Console.WriteLine(string.Format("", newComment));
        }



        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }

    }
}
