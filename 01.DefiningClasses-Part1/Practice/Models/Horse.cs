namespace Practice
{
    using System;

    class Horse : Mammal
    {
        //Fields
        public string name;


        //Constructor
        public Horse()
        {
            base.Age = 10;
        }


        //Methods
        public void ChangeAge(int newAge)
        {
            this.Age = newAge;
            Console.WriteLine(this.Age);
        }


        public void SayMyName()
        {
            Console.WriteLine("My name is {0}.", this.name);
        }

    }
}
