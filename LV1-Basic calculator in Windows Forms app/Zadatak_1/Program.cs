using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculation;

namespace Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int odabir;
            double result = 0, x, y;
            Console.WriteLine("Unesite dva broja.");
            Console.Write("Unesi prvi broj: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesi drugi broj: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Zbrajanje\n2.Mnozenje\n3.Oduzimanje\n4.Djeljenje");
            Console.Write("Odabir: ");
            odabir = Convert.ToInt32(Console.ReadLine());
            Calculator Casio = new Calculator();
            switch (odabir)
            {
                case 1: 
                    {
                        result = Casio.Add(x, y);
                        Console.WriteLine($"{x} + {y} = {result}");
                        break;
                    }
                case 2: 
                    {
                        result = Casio.Multiply(x, y);
                        Console.WriteLine($"{x} * {y} = {result}");
                        break;
                    }
                case 3:
                    {
                        result = Casio.Subtract(x, y);
                        Console.WriteLine($"{x} - {y} = {result}");
                        break;
                    }
                case 4:
                    {
                        result = Casio.Divide(x, y);
                        Console.WriteLine($"{x} / {y} = {result}");
                        break;
                    }
            }
            
            Console.ReadKey();
        }
    }
}
