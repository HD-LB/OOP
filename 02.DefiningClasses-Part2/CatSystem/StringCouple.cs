namespace CatSystem
{
   using System;
   using System.Collections.Generic;

   public class StringCouple
   {
      private List<string> keys;
      private List<string> values;

      //Constructors
      public StringCouple()
      {
         this.keys = new List<string>();
         this.values = new List<string>();
      }

      //Idexer
      public string this[string index]
      {
         get
         {
            var indexInKeys = this.keys.IndexOf(index);
            return this.values[indexInKeys];
         }
         set
         {
            var indexInKeys = this.keys.IndexOf(index);
            this.values[indexInKeys] = value;
         }
      }

      //Methods
      public void Add(string key, string value)
      {
         this.keys.Add(key);
         this.values.Add(value);
      }
   }
}
