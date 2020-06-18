namespace LectureEvlogi
{
   using System;

   public class Person : ICloneable
   {
        //Proparties
      public string Name { get; set; }

      public int Age { get; set; }

        //Method
      public object Clone()
      {
         return new Person()
         {
            Name = (string)this.Name.Clone(),
            Age = this.Age
         };
      }
   }
}