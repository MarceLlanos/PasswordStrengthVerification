using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class NormalSecurityPassword : ILevelSecurityPassword
    {
        ILevelSecurityPassword next;
        IVerifyConstructor resultVerify = new NormalVerifierContruct();
        public bool IsAtSecureLevel(string password)
        {
            int lenghtPassword = password.Length;
            if (lenghtPassword >=10 && lenghtPassword < 15)
            {
                return resultVerify.contructVerify(password);
            }
            if (next != null)
            {                
                next.IsAtSecureLevel(password);
            }
            return false;
            
        }

        public void NextLevel(ILevelSecurityPassword nextLevel)
        {
            this.next = nextLevel;
        }
    }
}
