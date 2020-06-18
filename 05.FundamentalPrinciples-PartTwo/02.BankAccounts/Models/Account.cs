namespace _02.BankAccounts
{

   using System;
   using Interface;
   using System.Text;

   public abstract class Account : ICalculationOfIntrest, IDeposit
   {
      private const string NegativeRateExceptionMsg = "Monthly intrest rate cannot be negative.";

      //Fields
      private Customer customer;
      private decimal balance;
      private decimal intrestPerMonth;

      //Constructors

      public Account(Customer customer, decimal balance, decimal interestPerMonth)
      {
         this.Customer = customer;
         this.Balance = balance;
         this.InterestPerMonth = interestPerMonth;
      }

      //Proparties
      public Customer Customer
      {
         get
         {
            return this.customer;
         }
         set
         {
            this.customer = value;
         }
      }

      public decimal Balance
      {
         get
         {
            return this.balance;
         }
        protected set
         {
            this.balance = value;
         }
      }

      public decimal InterestPerMonth
      {
         get
         {
            return this.intrestPerMonth;
         }
         private set
         {
            if (value < 0)
            {
               throw new ArgumentException(NegativeRateExceptionMsg);
            }
            this.InterestPerMonth = value;
         }
      }
      public AccountType AccountType { get; protected set; }

      //Methods
      public abstract void Deposit(decimal sum);
      

      public abstract decimal IntrestCalculation(int months);

      public override string ToString()
      {
         var text = new StringBuilder();
         text.AppendLine("Account: " + this.AccountType)
             .AppendLine("Balance: " + this.Balance)
             .AppendLine("Intrest Rate: " + this.InterestPerMonth)
             .AppendLine("Customer: " + Customer.ToString());

         return text.ToString();
      }

   }
}
