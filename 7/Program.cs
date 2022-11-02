using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            double A1 = 0; double B1 = 0; double C1 = 0;
            double A2 = 0; double B2 = 0; double C2 = 0;
            try
            {
                // first 3 number

                Console.WriteLine("Введите значение А1");
                A1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение B1");
                B1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение C1");
                C1 = double.Parse(Console.ReadLine());
                SortInc3(ref A1, ref B1, ref C1);
                Console.WriteLine("{0} {1} {2}", A1, B1, C1);
                Console.WriteLine();

                // second 3 number

                Console.WriteLine("Введите значение А2");
                A2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение B2");
                B2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение C2");
                C2 = double.Parse(Console.ReadLine());
                SortInc3(ref A2, ref B2, ref C2);
                Console.WriteLine("{0} {1} {2}", A2, B2, C2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    
        static void SortInc3(ref double A, ref double B, ref double C)
        {
            double temp1 =  0;
            if (C < 0) temp1 = C;

            // max

            if (C > temp1)
            {
                temp1 = C;
            }
            if (A > temp1)
            {
                temp1 = A;
                A = C;
                C = temp1;
            }
            if (B > temp1)
            {
                temp1 = B;
                B = C;
                C = temp1;
            }

            // min

            if (A < temp1)
            {
                temp1 = A;
            }
            if (B < temp1)
            {
                temp1 = B;
                B = A;
                A = temp1;
            }
            if (C < temp1)
            {
                temp1 = C;
                C = A;
                A = temp1;
            }

        }
    }
}
