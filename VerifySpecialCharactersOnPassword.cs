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

            for (int i = 0; i < password.Length; i++)
            {
                result = specialCharacter.Contains(password[i])?  result = 1: result = 0 ;
            }

            return result;
        }
    }
}
