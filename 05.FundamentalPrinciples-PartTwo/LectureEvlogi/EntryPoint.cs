//https://my.telerikacademy.com/Courses/LectureResources/Video/6099/%d0%92%d0%b8%d0%b4%d0%b5%d0%be-25-%d0%bc%d0%b0%d1%80%d1%82-2015-%d0%98%d0%b2%d0%b0%d0%b9%d0%bb%d0%be


namespace LectureEvlogi
{
    using System;
    using System.Collections.Generic;

    using Animals;


    public class EntryPoint
    {

        public static void SayAnimalName(IAnimal animal)// using Polymorphism
        {
            Console.WriteLine(animal.Name);
        }
        public static void Main()
        {
            IAnimal cat = new Cat("Pesho"); //Polymorphism

            Cat anotherCat = new Cat("Suzi", 3);

            Dog anotherDog = new Dog("Scharo", 6);

            List<IAnimal> animals = new List<IAnimal>(); //List of Polymorphism. Cat and Dog are IAnimal
            animals.Add(cat);
            animals.Add(anotherCat);
            animals.Add(anotherDog);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Speak());
            }

            SayAnimalName(cat);
            SayAnimalName(anotherCat);
            SayAnimalName(anotherDog);
        }
    }
}
