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

        public bool IsAtSecureLevel(string password)
        {
            var verifier = new ListVeriferCharacters();
            bool result = false;
            int lenghtPassword = password.Length;

            if (lenghtPassword >= 6 && lenghtPassword < 10)
            {
                result = verifier.VerifierList(password).Length == 3? true: false;
            }
            return false;
        }

        public void NextLevel(ILevelSecurityPassword nextLevel)
        {
            this.next = nextLevel;
        }
    }
}
