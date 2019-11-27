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

            foreach (var item in password)
            {
                if (lowerUpperCharacter.Contains(item))
                {
                    return result = 1;
                }
            }
            return result;
        }
    }
}
