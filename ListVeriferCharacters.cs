using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class ListVeriferCharacters
    {
        public string VerifierList(string password)
        {
            List<bool> list = new List<bool>();
            string result = string.Empty;

            list.Add(new VerifyDigitCharactersOnPassword().CharactersOnPassword(password) );
            list.Add(new VerifySpecialCharactersOnPassword().CharactersOnPassword(password) );
            list.Add(new VerifyLowerUpperCharactersOnPassword().CharactersOnPassword(password) );
            if (list.Equals(true))
            {
                result += "d";
            }
            return result;
        }
    }
}
