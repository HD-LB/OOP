namespace LectureEvlogi.Animals
{
    using System;

    public class Dog : Animal, IAnimal
    {
        //Constructor
        public Dog(string name, int age)
            :base(age)
        {
            this.Name = name;
        }

        //Method 
        public override string Speak()
        {
            return string.Format(base.Speak() + "Bow!", this.Name);
        }

        public string CatchBone()
        {
            return string.Format("{0} says I catched the bone!", this.Name);
        }
    }
}
