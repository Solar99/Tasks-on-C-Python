using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                int n;
                Console.WriteLine("Введите число элементов массива");
                n = Convert.ToInt16(Console.ReadLine());
                double[] number = new double[n];
                int i = 0;
                while (i < n)
                {
                    Console.WriteLine("Введите элемент массива");
                    number[i] = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    i++;
                }
                for (i = 0; i < n; i = i + 1)
                    Console.Write(number[i] + " ");
                int v = 0;
                Console.WriteLine("\nКратные трем:");
                for (i = 0; i < n; i++)
                    if (Convert.ToInt32(number[i]) % 3 == 0) { Console.WriteLine("number[" + i + "]=" + number[i]); v++; }
                Console.WriteLine("Всего:" + v);
                Console.ReadKey();
            }
        }
    }
}    

        
