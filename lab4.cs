// See https://aka.ms/new-console-template for more information
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            double max, min;
            Console.WriteLine("Введите размер массива ");
            n = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];
            double[] max_a = new double[n];
            double[] min_a = new double[n];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + Convert.ToString( i + 1) + "]=");
                a[i] = Convert.ToDouble(Console.ReadLine());
            };
            k = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((a[i] > a[i - 1]) && (a[i] > a[i + 1]))
                {
                    max_a[k] = a[i];
                    k++;
                }
                if ((a[i] < a[i - 1]) && (a[i] < a[i + 1]))
                {
                    min_a[k] = a[i];
                    k++;
                }
            }
            max = min_a[0];
            min = max_a[0];
            for (int i = 1; i <= k; i++)
            {
                if (min_a[i] > max)
                    max = min_a[i];
                if (max_a[i] < min)
                    min = max_a[i];
            }
 
            Console.WriteLine("Максимальный элемент среди локальных минимумов " + Convert.ToString(max));
            Console.WriteLine("Минимальный элемент среди локальных максимумов " + Convert.ToString(min));
            Console.ReadKey();
        }
    }
}


// int[] myArray;
        // myArray = new int [4];
        // myArray[1] = 3;
        // myArray[0] = 10;
        // int a = myArray[0];
        // Console.WriteLine(int a);
        // Console.ReadLine();