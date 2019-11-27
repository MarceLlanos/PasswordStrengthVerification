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
            DisplayerMessageAboutSecurityPassword displayMessage = new DisplayerMessageAboutSecurityPassword();
           

            Console.WriteLine("Verify a password:");
            string password = Console.ReadLine();
            Console.WriteLine("Result of verify:");
            Console.WriteLine(displayMessage.DisplayMessageAboutSecurityPassword(password)); 
            Console.ReadKey();
        }
    }
}
