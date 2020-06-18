namespace _02.BankAccounts
{
   using System;

   public class LoanAccount : Account
   {
      private const int NoInterestCompanyMonths = 2;
      private const int NoInterestIndividualMonths = 3;

      public LoanAccount(Customer customer, decimal balance, decimal interestPerMonth) 
         : base(customer, balance, interestPerMonth)
      {
         this.AccountType = AccountType.Deposit;
      }

      public override void Deposit(decimal sum)
      {
         this.Balance += sum;
      }

      public override decimal IntrestCalculation(int months)
      {
         if (this.Customer.CustomerType == CustomerType.Company)
         {
            if (months <= NoInterestCompanyMonths)
            {
               return 0;
            }

            return this.InterestPerMonth * (months - NoInterestCompanyMonths);
         }

         else if (this.Customer.CustomerType == CustomerType.Individual)
         {
            if (months <= NoInterestIndividualMonths)
            {
               return 0;
            }
            return this.InterestPerMonth * (months - NoInterestIndividualMonths);
         }
         return 0;
      }
   }
}
