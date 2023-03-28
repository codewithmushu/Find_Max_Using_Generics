using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] intArray = { 1, 2, 3, 4 };
            //double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            //char[] charArray = { 'H', 'E', 'A', 'T', 'E', 'R' };

            //Program.toPrint<int>(intArray);
            //Program.toPrint<double>(doubleArray);
            //Program.toPrint<char>(charArray);

            //PrintArray<int> intPrintArray = new PrintArray<int>(intArray);
            //intPrintArray.toPrint();

            //PrintArray<double> doublePrintArray = new PrintArray<double>(doubleArray);
            //doublePrintArray.toPrint();

            //PrintArray<char> charPrintArray = new PrintArray<char>(charArray);
            //charPrintArray.toPrint();

            //int num1 = 70;
            //int num2 = 30;

            //Console.WriteLine("Please enter first value ");

            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter second value ");

            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter third value ");

            //int num3 = Convert.ToInt32(Console.ReadLine());

            float val = FindMaximum<float>.MaximumIntegertNumber(9.5f , 8.2f, 4.2f);

            Console.WriteLine("{0} is greater ", val);


        }
    }
}
