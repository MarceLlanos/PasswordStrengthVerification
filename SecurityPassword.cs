using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class SecurityPassword : ISecurityPassword
    {
        int minRange;
        int maxRange;
        Range range;
        int lengthVerificationsMax;

        public SecurityPassword(Range range, int lengthVerificationsMax)
        {
            this.range = range;
            this.lengthVerificationsMax = lengthVerificationsMax;
        }


        public bool IsAtSecureLevel(string password)
        {
            var verifier = new CompositeCharactersVerifer();
            bool result = false;
            int lenghtPassword = password.Length;

            if (lenghtPassword >=range.GetMin()  && lenghtPassword < range.GetMax())
            {
                result = verifier.VerifierList(password) == lengthVerificationsMax ? true : false;
            }
            return result;
        }
    }
}
