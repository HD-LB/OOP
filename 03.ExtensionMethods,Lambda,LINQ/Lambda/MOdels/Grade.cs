namespace Lambda.MOdels
{
   public class Grade
   {
      //Constructor
      public Grade(int value)
      {
         this.Value = value;
      }

      //Proparties
      public int Value { get; set; }

      public bool IsSufficient
      {
         get
         {
            return this.Value >= 3;
         }         
      }
   }
}