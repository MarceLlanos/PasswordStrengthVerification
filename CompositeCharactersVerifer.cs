using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class CompositeCharactersVerifer
    {
        List<IVerifyCharacterOnPassword> list;
        public CompositeCharactersVerifer()
        {
            list = new List<IVerifyCharacterOnPassword>();
        }
        public int VerifierList(string password)
        {
            int result = 0;

            list.Add(new VerifyDigitCharactersOnPassword() );
            list.Add(new VerifySpecialCharactersOnPassword());
            list.Add(new VerifyLowerUpperCharactersOnPassword() );
            if (list.Equals(true))
            {
                result +=1;
            }
            return result;
        }
    }
}
