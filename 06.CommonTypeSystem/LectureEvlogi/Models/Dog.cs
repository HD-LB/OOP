namespace LectureEvlogi
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Dog : Animal, ICloneable, IComparable, IEnumerable<int>, IEnumerable
    {
        //Constructor
        public Dog()
        {

        }


        //Proparties  
        public Person Owner { get; set; }

        public int[] Arr { get; set; }


        //Method
        public object Clone()
        {
            var newDog = new Dog()
            {
                Age = this.Age,
                Name = (string)this.Name.Clone(),
                Owner = (Person)this.Owner.Clone()
            };

            return newDog;
        }

        public int CompareTo(Dog other)
        {
            return this.Age - other.Age;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            yield return this.Age;
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield return 6;
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        

        //public int CompareTo(Dog obj)
        //{
        //   throw new NotImplementedException();
        //}
    }
}
