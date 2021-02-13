using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Countries;

namespace ConsoleAppTester
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryRepository cR = new CountryRepository();
            List<Country> countries = cR.GetCountries();
            foreach (var Country in countries) 
            {
                Console.WriteLine($"{Country.Name}");
            }
            Console.ReadKey();
        }
    }
}
