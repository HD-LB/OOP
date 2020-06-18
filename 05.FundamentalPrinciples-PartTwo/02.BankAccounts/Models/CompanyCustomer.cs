namespace _02.BankAccounts
{
   using System;

   public class CompanyCustomer : Customer
   {
      //public CompanyCustomer(string name, string address, string email, string phomeNumeber) 
      //   : base(name, address, email, phomeNumeber)
      //{
      //   this.CustomerType = CustomerType.Company;
      //}

      //public override string ToString()
      //{
      //   return string.Format("Company: {0}", base.Name);
      //}

      public CompanyCustomer(string name)
         : this(name, string.Empty, string.Empty, string.Empty)
      {

      }

      public CompanyCustomer(string name, string address)
         : this(name, address, string.Empty, string.Empty)
      {

      }

      public CompanyCustomer(string name, string address, string email)
         : this(name, address, email, string.Empty)
      {

      }

      public CompanyCustomer(string name, string address, string email, string phomeNumeber)
         : base(name, address, email, phomeNumeber)
      {
         this.CustomerType = CustomerType.Individual;
      }
   }
}
