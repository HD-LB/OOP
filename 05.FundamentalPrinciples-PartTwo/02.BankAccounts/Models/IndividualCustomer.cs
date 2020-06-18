namespace _02.BankAccounts
{
   using System;

   public class IndividualCustomer : Customer
   {
      //public IndividualCustomer(string name, string address, string email, string phoneNumber)
      //   : base(name, address, email, phoneNumber)
      //{
      //   this.CustomerType = CustomerType.Individual;
      //}

      //public override string ToString()
      //{
      //   return string.Format("Individual: {0}", base.Name);
      //}

      public IndividualCustomer(string name)
         : this(name, string.Empty, string.Empty, string.Empty)
      {

      }

      public IndividualCustomer(string name, string address)
         : this(name, address, string.Empty, string.Empty)
      {

      }

      public IndividualCustomer(string name, string address, string email)
         : this(name, address, email, string.Empty)
      {

      }

      public IndividualCustomer(string name, string address, string email, string phomeNumeber)
         : base(name, address, email, phomeNumeber)
      {
         this.CustomerType = CustomerType.Individual;
      }
   }
}
