namespace _02.BankAccounts
{
   using System;
   using System.Collections.Generic;

   public abstract class Customer
   {
      private const string NameNullExceptionMsg = "A name has to be specified.";

      //Fields
      private CustomerType customerType;
      private string name;
      private string address;
      private string email;
      private string phoneNumber;
      private ICollection<Account> accounts;
      private string phomeNumeber;

        //Constructors
        public Customer(string name, string address, string email, string phomeNumeber)
      {
         this.name = name;
         this.address = address;
         this.email = email;
         this.phomeNumeber = phomeNumeber;
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

      public CustomerType CustomerType
      {
         get
         {
            return this.customerType;
         }
         protected set
         {
            this.customerType = value;
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

      public string Email
      {
         get
         {
            return this.email;
         }
         private set
         {
            this.email = value;
         }
      }

      public string PhoneNumber
      {
         get
         {
            return this.phoneNumber;
         }
         private set
         {
            this.phoneNumber = value;
         }
      }

      public ICollection<Account> Accounts
      {
         get
         {
            return this.accounts;
         }
         set
         {
            this.accounts = value;
         }
      }

      //Methods
      public override string ToString()
      {
         return Name + " - " + this.CustomerType;
      }


   }
}
