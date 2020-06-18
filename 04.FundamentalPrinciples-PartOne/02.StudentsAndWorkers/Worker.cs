namespace _02.StudentsAndWorkers
{
   using System;

   public class Worker : Human
   {
      //Fields
      private decimal weekSalary;
      private int workHoursPerDay;

      //Constructor
      public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay )
         : base(firstName, lastName)
      {
         this.WeekSalary = weekSalary;
         this.WorkHoursPerDay = workHoursPerDay;
      }


      //Proparties
      public decimal WeekSalary
      { get { return this.weekSalary;  }
         set
         {
            if (value < 90.00m)
            {
               throw new ArgumentException("The salary cannot be less than 90.00.");
            }

            this.weekSalary = value;
         }
      }

      public int WorkHoursPerDay
      { get { return this.workHoursPerDay; }
         set
         {
            if (value < 4 || value > 13)
            {
               throw new ArgumentException("The work hours per day have to be between 4 and 13.");
            }

            this.workHoursPerDay = value;
         }
      }


      //Methods
      public decimal MoneyPerHour(int workingDays)
      {
         decimal moneyPerHour = this.WeekSalary / (workingDays * (decimal)this.workHoursPerDay);
         return moneyPerHour;
      }
   }
}
