using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class VerifyDigitCharactersOnPassword : IVerifyCharacterOnPassword
    {

        public bool CharactersOnPassword(string password)
        {
            string digitCharacter = new DigitCharacter().GetCharacter();
            bool result = false;
            for (int i = 0; i < password.Length ; i++)
            {
                result = digitCharacter.Contains(password[i])?  result = true: result = false ;
            }
            return result;
        }
        
    }
}
