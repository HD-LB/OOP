namespace DelegatesDemos
{
   using System;

   public static class DelegatesDemos
   {

      public delegate int StringDelegate(string text);
      public delegate void VoidDelegate(string text);

      static void Main()
      {

         StringDelegate dlg = new StringDelegate(int.Parse);

         Console.WriteLine(dlg("13"));

         VoidDelegate voidDlg = new VoidDelegate(Console.WriteLine);
         voidDlg("some text");

      }
   }
}
