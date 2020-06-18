namespace LectureEvlogi.Animals
{
    using System;


    public abstract class Animal : IAnimal
    {
        //Field
        private int age;

        //Constructor
        public Animal(int age)
        {
            this.Age = age;
        }

        //Proparties
        public string Name { get; protected set; }
             

        public int Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (value > 1000)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.age = value;
            }
        }


        //Methods
        public virtual string Speak() //"Vertual" Method can be changed by the Inheritant with an "Override"
        {
            return "{0} says  ";
        }
    }
}
