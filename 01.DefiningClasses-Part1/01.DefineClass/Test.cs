//https://www.youtube.com/watch?v=uj19f0Xg7Ms HomeWork

using System;

namespace _01.DefineClass
{
    class Test
    {
        static void Main()
        {
            var gsm = new GSM("Nokia 3310", "Nokia", 234.5m, "Ivan");

            Console.WriteLine(gsm);

            for (int i = 0; i < 10; i++)
            {
                gsm.AddCall(new Call()
                {
                    DailedPhoneNumber = "0001" + 1,
                    Duration = (uint)((i + 1) * 10)
                }
                );               
            }
            Console.WriteLine(gsm.CalculateTotalCost(0.12m));

            Console.WriteLine();
            Console.WriteLine();

            var maxCall = new Call();
            foreach (Call call in gsm.CallHistory)
            {
                Console.WriteLine(call);
                if (maxCall.Duration < call.Duration)
                {
                    maxCall = call;
                }
            }

            gsm.DeleteCall(maxCall);
            Console.WriteLine(gsm.CalculateTotalCost(0.12m));
        }
    }
}
