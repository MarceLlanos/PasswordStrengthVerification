using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class Program
    {
        static void Main(string[] args)
        {
            ILevelSecurityConstructor passwordSecurity = new LevelSecurityConstructor();

            Console.WriteLine("Input a password:");
            string password = Console.ReadLine();
            Console.WriteLine(passwordSecurity.ConstructLevelSecurity(password));
            Console.ReadKey();
        }
    }
}
