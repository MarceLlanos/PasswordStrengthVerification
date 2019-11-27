using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class VerifySpecialCharactersOnPassword: IVerifyCharacterOnPassword
    {
        List<IVerifyCharacterOnPassword> verifyCharacterOnPasswords = new List<IVerifyCharacterOnPassword>();

        public bool CharactersOnPassword(string password)
        {
            string specialCharacter = new SpecialCharacter().GetCharacter();

            for (int i = 0; i < password.Length; i++)
            {
                specialCharacter.Contains(password[i]);
            }

            return false;
        }
    }
}
