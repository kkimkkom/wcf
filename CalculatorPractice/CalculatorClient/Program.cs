﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorReference.CalculatorServiceClient client = new CalculatorReference.CalculatorServiceClient();
            string choice = "";
            while (!choice.Equals("5"))
            {
                Console.WriteLine("\t\tCalculator");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Sub");
                Console.WriteLine("3. Mul");
                Console.WriteLine("4. Div");
                Console.WriteLine("5. Exit");
                Console.Write("\tEnter your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Number 1: ");
                        double n1 = double.Parse(Console.ReadLine());
                        Console.Write("Enter Number 2: ");
                        double n2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("The sum is : " + client.Add(n1,n2));
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;

                    default:
                        break;
                }
            }


            Console.ReadKey();

        }
    }
}
