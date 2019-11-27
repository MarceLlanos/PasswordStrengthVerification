using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class ListVeriferCharacters
    {
        public int VerifierList(string password)
        {
            List<bool> list = new List<bool>();
            int result = 0;

            list.Add(new VerifyDigitCharactersOnPassword().CharactersOnPassword(password) );
            list.Add(new VerifySpecialCharactersOnPassword().CharactersOnPassword(password) );
            list.Add(new VerifyLowerUpperCharactersOnPassword().CharactersOnPassword(password) );
            if (list.Equals(true))
            {
                result +=1;
            }
            return result;
        }
    }
}
