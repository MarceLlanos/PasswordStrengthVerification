using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class VerifyDigitCharactersOnPassword : IVerifyCharacterOnPassword
    {

        public int CharactersOnPassword(string password)
        {
            string digitCharacter = new DigitCharacter().GetCharacter();
            int result = 0;
            foreach (var item in password)
            {
                if (digitCharacter.Contains(item))
                {
                    return result = 1;
                }

            }

            return result;
        }
        
    }
}
