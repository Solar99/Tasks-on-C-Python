using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Вячеслав";
            Console.WriteLine("Введите имя");
            string name2 = Console.ReadLine();
            if (name2 == name1)
            {
                Console.WriteLine("Привет," + name2);
            }
            else
            {
                Console.WriteLine("Нет такого имени");
            }

            }    
        }
    }

