namespace _03.RangeExceptions
{
   using System;

   public class IndividualRangeExceptions<T> : ApplicationException
   {
      //Fields
      private T start;
      private T end;
      //private const string Msg = "Out Of Range!";

      //Constructors

      public IndividualRangeExceptions(T start, T end)
         : this(string.Empty, null, start, end)
      {
      }

      public IndividualRangeExceptions(string message, T start, T end)
         : this(message, null, start, end)
      {

      }

      public IndividualRangeExceptions(string message, Exception innerException, T start, T end)
         : base(string.Format("{0} should be in range [{1} - {2}]", message, start, end), innerException)
      {
         this.Start = start;
         this.End = end;
      }

      //Proparties
      public T Start
      {
         get { return this.start; }
         set { this.start = value; }
      }

      public T End
      {
         get { return this.end; }
         set { this.end = value; }
      }


   }
}
