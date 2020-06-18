namespace _03.AnimalHierarchy
{
   using System;
   using System.Collections.Generic;
   using System.Linq;


   public abstract class Animal : ISound
   {
      //Fields
      private int age;
      private string name;


      //Constructors
      public Animal(int age, string name, Gender gender)
      {
         this.Age = age;
         this.Name = name;
         this.Sex = gender;               
      }


      //Proparties
      public int Age
      {
         get
         {
            return this.age;
         }
         private set
         {
            if (value < 0)
            {
               throw new ArgumentException("Age cannot be a negative number.");
            }
            this.age = value;
         }
      }

      public string Name
      {
         get
         {
            return this.name;
         }
         private set
         {
            if (string.IsNullOrEmpty(value))
            {
               throw new ArgumentException("The name cannot be empty.");
            }
            this.name = value;
         }
      }

      public Gender Sex { get; set; }

      public static double CalculateAvrgAge(IEnumerable<Animal> animals)
      {
         return animals.Average(a => a.Age);
      }


      public abstract string MySound { get; }
   }
}
