namespace CatSystem
{
   using System;

   public class GenericList<T>
   {
      private T[] elements;
      private int index;

      public GenericList()
      {
         this.elements = new T[16];

         this.index = 0;
      }

      public void Add(T element)
      {
         this.elements[this.index] = element;
         this.index++;

         if (this.index == this.elements.Length)
         {

         }
      }


      //Indexers
      public T this[int index] //where T is an int
      {
         get
         {
            return this.elements[index];
         }
         set
         {
            if (index < 0 || index >= this.elements.Length)
            {
               throw new IndexOutOfRangeException();
            }
            this.elements[index] = value;
         }
      }
   }
}
