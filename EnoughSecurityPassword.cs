using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class EnoughSecurityPassword : ILevelSecurityPassword
    {
        ILevelSecurityPassword nextLevel;
        IVerifyConstructor verifyConstructor = new EnoughVerifierConstruct();
        public bool IsAtSecureLevel(string password)
        {
            
            int lenghtPassword = password.Length;
            if (lenghtPassword >= 15 && lenghtPassword < 20 )
            {                
                return verifyConstructor.contructVerify(password);
            }
            if (nextLevel!= null)
            {
                nextLevel.IsAtSecureLevel(password);
            }
            return false;
        }

        public void NextLevel(ILevelSecurityPassword nextLevel)
        {
            this.nextLevel = nextLevel;
        }
    }
}
