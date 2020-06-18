namespace LectureEvlogi.Animals
{
   using System;

   public class Cat : Animal, IAnimal
   {
      public Cat(string name, int age = 0)
            :base (age)
      {           
         this.Name = name;
      }

      public override string Speak()
      {
         return string.Format(base.Speak() + "Meow!", this.Name);
        
      }

      public string Purring()
      {
         return string.Format("{0} says Purrr!", this.Name);
      }
   }
}
