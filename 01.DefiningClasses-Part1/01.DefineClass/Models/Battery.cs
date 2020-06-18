using System;
using System.Text;

namespace _01.DefineClass
{
   public class Battery
   {
      private string model;

      private int hoursIdle;

      private int hoursTalk;

      private BatteryType batteryType;



      public BatteryType BatteryType
      {
         get { return batteryType; }
         set { batteryType = value; }
      }

      public int HoursTalk
      {
         get { return hoursTalk; }
         set { hoursTalk = value; }
      }
      
      public int HouresIdle
      {
         get { return hoursIdle; }
         set { hoursIdle = value; }
      }
      
      public string Model
      {
         get { return model; }
         set { model = value; }
      }

  

      public override string ToString()
      {
         StringBuilder result = new StringBuilder();
         if (this.Model == null)
         {
            result.AppendLine("No battery");
         }
         else
         {
            result.AppendLine(string.Format("Model: {0}",this.Model));
            result.AppendLine(string.Format("Battery Type: {0}", this.BatteryType));
            result.AppendLine(string.Format("Hours Idle: {0}",this.HouresIdle));
            result.AppendLine(string.Format("Hours Talk: {0}",this.HoursTalk));           
         }
         return result.ToString();
      }

   }
}
