using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class VerifyLowerUpperCharactersOnPassword: IVerifyCharacterOnPassword
    {
        public int CharactersOnPassword(string password)
        {
            string lowerUpperCharacter = new LowerUpperCharacter().GetCharacter();
            int result = 0;

            for (int i = 0; i < password.Length; i++)
            {
                result = lowerUpperCharacter.Contains(password) ? result = 1 : result = 0;
            }
            return result;
        }
    }
}
