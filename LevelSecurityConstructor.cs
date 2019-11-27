using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class LevelSecurityConstructor : ILevelSecurityConstructor
    {
        public string ConstructLevelSecurity(string password)
        {
            ILevelSecurityPassword highSecure = new HighSecurityPassword();
            ILevelSecurityPassword enoughSecure = new EnoughSecurityPassword();
            ILevelSecurityPassword normalSecure = new NormalSecurityPassword();
            ILevelSecurityPassword lowSecure = new LowSecurityPassword();

            highSecure.NextLevel(enoughSecure);
            enoughSecure.NextLevel(normalSecure);
            normalSecure.NextLevel(lowSecure);

            string result= string.Empty;

            if (highSecure.IsAtSecureLevel(password))
            {
                return result = "Password Secure";
            }

            return result = "Password Insecure";
           
        }
    }
}
