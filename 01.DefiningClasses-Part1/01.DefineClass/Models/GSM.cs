//https://www.youtube.com/watch?v=uj19f0Xg7Ms
//https://my.telerikacademy.com/Courses/LectureResources/Video/6115/Видео-21-март-2015-Евлоги

namespace _01.DefineClass
{
   using System;
   using System.Collections.Generic;
   using System.Text;

   public class GSM
   {
      //Fields  Propfull + Tab Tab
      #region Fields
      private string model;

      private string manufacturer;

      private decimal? price;

      private string owner;

      private Battery battery;

      private Display display;

      private static GSM iPhone4S;

      private List<Call> callHistory;

      #endregion


      //Constructors ctor + Tab Tab
      #region Constructors
      static GSM()
      {
         iPhone4S = new GSM("iPhone 4S", "Apple", 1000.0m, "Person", new Battery(), new Display() { Size = 4, NumberOfColors = "16M" });
      }

      public GSM(string model, string manufacturer)
      {
         this.Model = model;
         this.Manufacturer = manufacturer;
         this.CallHistory = new List<Call>();      
        
      }

      public GSM(string model, string manufacturer, decimal price)
         : this(model, manufacturer)
      {
         this.Price = price;
      }

      public GSM(string model, string manufacturer, string owner)
         : this(model, manufacturer)
      {
         this.Owner = owner;
      }

      public GSM(string model, string manufacturer, decimal price, string owner)
         : this(model, manufacturer, owner)
      {
         this.Price = price;
      }

      public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
         : this(model, manufacturer, price, owner)
      {
         this.Battery = battery;
         this.Display = display;
      }
      #endregion


      //Proparties prop Tab + Tab
      #region Proparties

      public static GSM IPhone4S { get { return iPhone4S; } }


      public List<Call> CallHistory
      {
         get
         {
            return this.callHistory;
         }
         set
         {
            if (this.callHistory == null)
            {
               this.callHistory = new List<Call>();
            }

            this.callHistory.Clear();
            this.callHistory = value;
         }
      }


      public Display Display
      {
         get { return display; }
         set
         {
            if (value == null)
            {
               throw new ArgumentException();
            }
            this.display = value;
         }
      }


      public Battery Battery
      {
         get { return battery; }
         set {
            if (value == null)
            {
               throw new ArgumentException();
            }

            this.battery = value; }
      }


      public string Owner
      {
         get { return owner; }
         set
         {
            if (string.IsNullOrEmpty(value))
            {
               throw new ArgumentException();
            }

            this.owner = value;
         }
      }


      public decimal? Price
      {
         get { return price; }
         set
         {
            if (value == null)
            {
               throw new ArgumentException();
            }

            this.price = value;
         }
      }


      public string Manufacturer
      {
         get { return manufacturer; }
         set
         {
            if (string.IsNullOrEmpty(value))
            {
               throw new ArgumentException();
            }

            this.manufacturer = value;
         }
      }


      public string Model
      {
         get { return model; }
         set
         {
            if (string.IsNullOrEmpty(value))
            {
               throw new ArgumentException();
            }

            this.model = value;
         }
      }
      #endregion


      //Methods
      #region Methods

      public void AddCall(Call call)
      {
         this.callHistory.Add(call); //through the Field
      }

      public void DeleteCall(Call call)
      {
         this.callHistory.Remove(call);
      }

      public void ClearHistory()
      {
         this.callHistory.Clear();
      }

      public decimal CalculateTotalCost(decimal fixedPrice)
      {
         ulong totalDuration = 0;

         foreach (Call call in this.callHistory)
         {
            totalDuration += (ulong)call.Duration;
         }

         return fixedPrice * (decimal)(totalDuration/60); //per minute
      }


      //4. 
      public override string ToString()
      {
         StringBuilder sb = new StringBuilder();
         sb.AppendLine(string.Format("Model: {0}", this.Model));
         sb.AppendLine(string.Format("Manufacturer: {0}", this.Manufacturer));
         sb.AppendLine(string.Format("Price: {0}", this.Price));
         sb.AppendLine(string.Format("Owner: {0}", this.Owner));
         sb.AppendLine(string.Format("Battery: {0}", this.Battery));
         sb.AppendLine(string.Format("Display: {0}", this.Display));

         return sb.ToString();
      }

      #endregion





   }
}
