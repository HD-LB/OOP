namespace _02.BankAccounts
{   
   using System;
   using Interface;

   public class DepositAccount : Account, IWithdraw
   {
      private const string WithdrawExceptionMsg = "The account has not have enough assets.";

      
      //Constructors
      public DepositAccount(Customer customer, decimal balance, decimal interestPerMonth) 
         : base(customer, balance, interestPerMonth)
      {
         this.AccountType = AccountType.Deposit;
      }

      
      //Methods
      public void Withdraw(decimal sum)
      {
         if (sum > this.Balance)
         {
            throw new ArgumentException(WithdrawExceptionMsg);
         }
         this.Balance -= sum;
      }

      public override void Deposit(decimal sum)
      {
         this.Balance += sum;
      }

      public override decimal IntrestCalculation(int months)
      {
         if (this.Balance > 0 && this.Balance < 1000)
         {
            return 0;
         }
         return this.InterestPerMonth * months;
      }

   }
}
