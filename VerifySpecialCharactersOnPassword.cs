using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class VerifySpecialCharactersOnPassword: IVerifyCharacterOnPassword
    {
        public int CharactersOnPassword(string password)
        {
            string specialCharacter = new SpecialCharacter().GetCharacter();
            int result = 0;
            foreach (var item in password)
            {
                if (specialCharacter.Contains(item))
                {
                    return result = 1;
                }
            }

            return result;
        }
    }
}
