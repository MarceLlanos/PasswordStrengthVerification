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
            for (int i = 0; i < password.Length ; i++)
            {
                result = digitCharacter.Contains(password[i])?  result = 1: result = 0 ;
            }
            return result;
        }
        
    }
}
