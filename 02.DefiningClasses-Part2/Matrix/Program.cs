namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models;


    class Program
    {
        static void Main()
        {
            ////OPP Homework (17)
            //string[] arr = new[] { "asd", "sfudeg", "wrfe", "wertyuiopa" };

            //var longest =
            //      (from str in arr
            //       orderby str.Length descending
            //       select str.Length).FirstOrDefault(); // select str).FirstOrDefault();


            //Console.WriteLine(longest);



            int row = 4, col = 5;
            var matrix1 = new MatrixTest<int>(row, col);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrix1[r, c] = r + c + 10;
                }
            }


            row = 5;
            col = 3;
            var matrix2 = new MatrixTest<int>(row, col);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrix2[r, c] = r + c;
                }

            }

            Console.WriteLine(matrix1);
            Console.WriteLine(matrix2);

            //Console.WriteLine(matrix1 + matrix2); // for m1[r = 4, c = 3] and m2[r = 4, c = 3]
            //Console.WriteLine(matrix1 - matrix2);
            Console.WriteLine(matrix1 * matrix2);

            if (matrix1)
            {
                Console.WriteLine("YES"); //no 0's
            }
            else
            {
                Console.WriteLine("NO");
            }

            Type type = typeof(MatrixTest<int>);
            object[] attr = type.GetCustomAttributes(false);
            foreach (var item in attr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
