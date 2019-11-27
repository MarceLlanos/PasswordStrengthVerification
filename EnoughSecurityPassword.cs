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
               

        public bool IsAtSecureLevel(string password)
        {
            var verifier = new ListVeriferCharacters();
            bool result = false;
            int lenghtPassword = password.Length;
            
            if (lenghtPassword >= 15 && lenghtPassword < 20 )
            {
                result = verifier.VerifierList(password).Length == 1? true: false;
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
