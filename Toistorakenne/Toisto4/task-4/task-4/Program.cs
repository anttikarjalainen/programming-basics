﻿using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Ohjelma laskee luvut yhteen alkaen annetusta arvosta: ");
            string userInput = Console.ReadLine();
          
            int number = int.Parse(userInput);
            
            int i = 0;
            int f = 0;

            if (number > 0)
            {
                do
                {
                    i = i + 1;

                    f = f + i;

                } while (i < number);
            }
            else
            {
                do
                {
                    i = i - 1;
                    f = f + i;
                } while (i > number);
            }


            Console.WriteLine($"Syötit {i}\n Vastaus on {f}");
            Console.ReadKey();
        }
    }
}
