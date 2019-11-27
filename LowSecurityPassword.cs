using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class LowSecurityPassword : ILevelSecurityPassword
    {
        ILevelSecurityPassword next;
        IVerifyConstructor verifyResult = new LowVerifierConstruct();

        public bool IsAtSecureLevel(string password)
        {
            int lenghtPassword = password.Length;
            if (lenghtPassword >= 6 && lenghtPassword < 10)
            {
                return verifyResult.contructVerify(password);
            }
            return false;
        }

        public void NextLevel(ILevelSecurityPassword nextLevel)
        {
            this.next = nextLevel;
        }
    }
}
