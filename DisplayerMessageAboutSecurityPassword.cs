using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class DisplayerMessageAboutSecurityPassword
    {
        public string DisplayMessageAboutSecurityPassword(string password)
        {
            ISecurityConstructor passwordSecurity = new ConstructorSecurity();
            

            if (passwordSecurity.SecurityConstruct().IsAtSecureLevel(password))
            {
                return "The Password is Secure!";
            }
            return "Password is Insecure"; ;
        }
    }
}
