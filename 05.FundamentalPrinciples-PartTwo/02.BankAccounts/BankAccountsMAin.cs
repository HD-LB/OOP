//•A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts.Customers could be individuals or companies.
//•All accounts have customer, balance and interest rate (monthly based). ◦Deposit accounts are allowed to deposit and with draw money.
//◦Loan and mortgage accounts can only deposit money.

//•All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months* interest_rate.
//•Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//•Deposit accounts have no interest if their balance is positive and less than 1000.
//•Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//•Your task is to write a program to model the bank system by classes and interfaces.
//•You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.


namespace _02.BankAccounts
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public class BankAccountsMAin
   {
      static void Main()
      {

         Bank bank = LoadAccounts();
         Console.WriteLine(bank);
      }

      private static Bank LoadAccounts()
      {
         Bank bank = new Bank("DSK");

         bank.AddAccount(new MortgageAccount(new IndividualCustomer("Pesho Peshev"), 2000.0m, 14));
         bank.AddAccount(new DepositAccount(new CompanyCustomer("Cisco"), 10000.0m, 25));
         bank.AddAccount(new LoanAccount(new IndividualCustomer("Maria Petrova"), 3400.0m, 12));

         return bank;
      }
   }
}
