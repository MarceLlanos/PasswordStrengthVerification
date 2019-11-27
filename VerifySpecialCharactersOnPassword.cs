using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class VerifySpecialCharactersOnPassword: IVerifyCharacterOnPassword
    {
        public bool CharactersOnPassword(string password)
        {
            string specialCharacter = new SpecialCharacter().GetCharacter();
            bool result = false;

            for (int i = 0; i < password.Length; i++)
            {
                result = specialCharacter.Contains(password[i])?  result = true: result = false ;
            }

            return result;
        }
    }
}
