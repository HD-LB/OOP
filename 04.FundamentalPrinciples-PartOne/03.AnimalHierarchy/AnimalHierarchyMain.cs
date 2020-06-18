//•Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.Dogs, frogs and cats are Animals.All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats.All animals are described by age, name and sex.Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
//•Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method(you may use LINQ).


namespace _03.AnimalHierarchy
{
   using System;
   using System.Linq;

   public class AnimalHierarchyMain
   {
      static void Main()
      {

         Animal[] animals =
         {
            new Dog(4, "Ginka", Gender.Female),
            new Dog (5, "Rex", Gender.Male),
            new Dog(9, "Pedro", Gender.Male),
            new Dog(2, "Oskar", Gender.Male),

            new Cat(5, "Tochka", Gender.Female),
            new TomCat(2, "Tiger", Gender.Male),
            new Kitten(1, "Puma", Gender.Female),

            new Frog(1, "Ivo", Gender.Male)

         };

         var dogs = animals.Where(d => d is Dog);
         var cats = animals.Where(c => c is Cat);
         var frogs = animals.Where(f => f is Frog);



         

         Console.WriteLine("Dogs' avarige age is: {0}", Dog.CalculateAvrgAge(dogs));
         Console.WriteLine("Cats' avarige age is: {0}", Cat.CalculateAvrgAge(cats));
         Console.WriteLine("Frogs' avarige age is: {0}", Frog.CalculateAvrgAge(frogs));
      }
   }
}
