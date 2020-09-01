using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace K205ConsoleCarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("Bmw", "M5", 12, 80);
            Car mer = new Car("Mercedes", "E-class", 12, 80);

            string userMessage;
            do
            {

                Console.WriteLine("Welcome We are Azpetrol");
                Console.WriteLine("1.Go");
                Console.WriteLine("2.TopUp");
                Console.WriteLine("3.Stop");
                Console.WriteLine("4.Reset Km");
                Console.WriteLine("5.Exit");

                userMessage = Console.ReadLine();
                if (IsNumber(userMessage))
                {
                    switch (userMessage)
                    {
                        case "1":
                            bmw.GO();
                            break;

                        case "2":
                            bmw.TopUp();
                            break;

                        case "3":
                            bmw.Stop();
                            break;
                        case "4":
                            bmw.Reset();
                            break;
                        default:
                            Console.WriteLine("Please only top number!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please write only number");
                }

            } while (userMessage != "5");
        }

        static bool IsNumber(string number)
        {
            try
            {
                Convert.ToInt32(number);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
