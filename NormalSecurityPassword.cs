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

        public bool IsAtSecureLevel(string password)
        {
            var verifier = new ListVeriferCharacters();
            bool result = false;
            int lenghtPassword = password.Length;

            if (lenghtPassword >=10 && lenghtPassword < 15)
            {
                result = verifier.VerifierList(password).Length == 2 ? true : false;

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
