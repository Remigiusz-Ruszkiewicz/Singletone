using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    class Program
    {
        static User user = null;
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj Imię");
            var name = Console.ReadLine();
            Console.WriteLine("Podaj Nazwisko");
            var lastname = Console.ReadLine();
            Console.WriteLine("Podaj Hasło");
            var password = Console.ReadLine();
            user = User.Instance(name,lastname,password);
            var newuser = User.Instance("Roman","Nowak","aaa");
            Console.WriteLine($"{user.Name} {user.LastName}");
            Console.WriteLine($"{newuser.Name} {newuser.LastName}");
            if (newuser.HasAcces)
            {
                Console.WriteLine("OK");
            }
            Console.Read();
        }

    }
}
