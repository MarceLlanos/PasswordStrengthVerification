using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class VerifyLowerUpperCharactersOnPassword: IVerifyCharacterOnPassword
    {
        public bool CharactersOnPassword(string password)
        {
            string lowerUpperCharacter = new LowerUpperCharacter().GetCharacter();
            bool result = false;

            for (int i = 0; i < password.Length; i++)
            {
                result = lowerUpperCharacter.Contains(password[i]) ? result = true : result = false;
            }
            return result;
        }
    }
}
