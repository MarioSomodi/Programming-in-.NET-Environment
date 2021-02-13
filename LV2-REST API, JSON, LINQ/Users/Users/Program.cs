using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersLib;

namespace Users
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository uR = new UserRepository();
            List<User> users = uR.DohvatiKorisnike();
            List<User> chinaUsers = users.Where(x => x.Country == "China").ToList();
            Console.WriteLine("Every third user from china:");
            for (int i = 2; i < chinaUsers.Count(); i = i + 3) 
            {
                Console.WriteLine($"Name: {chinaUsers[i].firstName}");
                Console.WriteLine($"Last name: {chinaUsers[i].firstName}");
                Console.WriteLine($"Email: {chinaUsers[i].Email}");
                Console.WriteLine($"Country: {chinaUsers[i].Country}");
                Console.WriteLine($"Last Modified: {chinaUsers[i].Modified}");
                Console.WriteLine($"VIP: {chinaUsers[i].Vip}");
            }
            Console.Write("Enter one letter of the alphabeth: ");
            string letter = Console.ReadLine();
            List<User> australianUsers = users.Where(x => x.Country == "Russia" && x.lastName.StartsWith(letter.ToUpper())).ToList();
            Console.WriteLine($"Every user from Russia whose name starts with the letter '{letter}':");
            for (int i = 0; i < australianUsers.Count(); i++)
            {
                Console.WriteLine($"Name: {australianUsers[i].firstName}");
                Console.WriteLine($"Last name: {australianUsers[i].lastName}");
                Console.WriteLine($"Email: {australianUsers[i].Email}");
                Console.WriteLine($"Country: {australianUsers[i].Country}");
                Console.WriteLine($"Last Modified: {australianUsers[i].Modified}");
                Console.WriteLine($"VIP: {australianUsers[i].Vip}");
            }
            var userGroup = from user in users
                            group user.lastName by user.lastName;
            
            Console.WriteLine("Ponavljanje prezimena:");
            foreach (var group in userGroup) 
            {
                Console.WriteLine($"Prezime '{group.Key}' je u bazi podataka uneseno {group.Count()} puta.'");
            }

            /*foreach (var lastName in lastNames) 
            {
                int count = 0;
                foreach (var userLastName in users) 
                {
                    if (lastName == userLastName.lastName) 
                    {
                        count++;    
                    }
                }
                Console.WriteLine($"Prezime '{lastName} je u bazi podataka uneseno {count} puta.'");
            }*/

            Console.ReadKey();
        }
    }
}
