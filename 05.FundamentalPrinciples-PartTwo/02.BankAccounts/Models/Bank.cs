namespace _02.BankAccounts
{
   using System;
   using System.Collections.Generic;
   using System.Text;

   public class Bank
   {
      private const string NameNullExceptionMsg = "The name of the bank has to be specified.";

      //Fields
      private string name;
      private string address;
      private ICollection<Account> accounts;

      //Constructors
      public Bank(string name)
         :this(name, string.Empty)
      {

      }
      public Bank(string name, string address)
      {
         this.Name = name;
         this.Address = address;
         this.Accounts = new HashSet<Account>();
      }

      //Proparties
      public string Name
      {
         get
         {
            return this.name;
         }
         private set
         {
            if (string.IsNullOrEmpty(value))
            {
               throw new ArgumentException(NameNullExceptionMsg);
            }
            this.name = value;
         }
      }

      public string Address
      {
         get
         {
            return this.address;
         }
         private set
         {
            this.address = value;
         }
      }

      public virtual ICollection<Account> Accounts
      {
         get
         {
            return this.accounts;
         }
         private set
         {
            this.accounts = value;
         }
      }

      //Methods

      public void AddAccount(Account account)
      {
         this.Accounts.Add(account);
      }

      public override string ToString()
      {
         var sb = new StringBuilder();
         sb.AppendLine(this.Name);
         sb.AppendLine();

         foreach (var account in this.Accounts)
         {
            sb.AppendLine(account.ToString()).AppendLine();
         }

         return sb.ToString();
      }

   }
}
