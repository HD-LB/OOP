namespace PetStore
{
    using System;
    using System.Collections.Generic;

    using AnimalKingdom.Models;
    using AnimalKingdom.Interfaces;

    public class PetStore
    {
        static void Main()
        {
            Mammal mammal = new Mammal();
            PetHamster hammy = new PetHamster();
            hammy.ProvokeHappiness();
            hammy.Eat(new Food());

            List<IAnimal> list = new List<IAnimal>();
            list.Add(new Hamster());
            list.Add(new Monster());

            //Abstraction
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6 };
            PrintOnConsole(nums);

            string[] otherNums = new string[] { "10", "20", "30" };
            PrintOnConsole(otherNums);

        }

        private static void PrintOnConsole<T>(IEnumerable<T> collection) //Prints both List<int> and string[]
        {
            foreach (var num in collection)
            {
                Console.WriteLine(num);
            }
        }
    }
}
