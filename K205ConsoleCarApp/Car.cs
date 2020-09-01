using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K205ConsoleCarApp
{
    class Car
    {
        public string Marka;
        public string Model;
        public decimal FuelEff;
        public int MaxFuel;
        public decimal CurrentFuel;
        public decimal GlobalKm;
        public decimal LocalKM;

        public Car(string Marka, string Model, int FuelEff, int MaxFuel, int CurrentFuel = 80)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.FuelEff = FuelEff;
            this.MaxFuel = MaxFuel;
            this.CurrentFuel = CurrentFuel;
        }
        public void GO()
        {
            Console.Write("Please km:");
            string neededKm = Console.ReadLine();
            if (IsNumber(neededKm))
            {
                decimal neededkmInt = Convert.ToDecimal(neededKm);
                if (neededkmInt / 100 * FuelEff <= CurrentFuel)
                {
                    CurrentFuel -= neededkmInt / 100 * FuelEff;
                    GlobalKm += neededkmInt;
                    LocalKM += neededkmInt;
                    Console.WriteLine($"Siz {neededkmInt} km yol getdiniz.Hal-hazirda {CurrentFuel}lr benzin qaldi");
                    Console.WriteLine("Gedişi bitirmek üçün 1");
                    string enddedKm = Console.ReadLine();


                }
                else
                {
                    Console.WriteLine("Please topUp");
                }

            }
        }

        public void Stop()
        {
            Console.WriteLine($"Local km:{LocalKM} GlobalKm:{GlobalKm}");
        }
        public void Reset()
        {
            LocalKM = 0;
            Console.WriteLine($"Local km reset");
        }

        public void TopUp()
        {
            Console.Write("Please write lt:");
            string neededFuel = Console.ReadLine();
            if (IsNumber(neededFuel))
            {
                decimal needFuelDec = Convert.ToDecimal(neededFuel);
                if (needFuelDec+CurrentFuel<=MaxFuel)
                {
                    CurrentFuel += needFuelDec;
                    Console.WriteLine("Yaxsi yol");
                }
                else
                {
                    Console.WriteLine("Gozun doysun");
                }

            }
            else
            {
                Console.WriteLine("");
            }
        }

        bool IsNumber(string number)
        {
            try
            {
                Convert.ToDecimal(number);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
