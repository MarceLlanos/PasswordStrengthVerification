using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class VerifyDigitCharactersOnPassword : IVerifyCharacterOnPassword
    {
        IVerifyCharacterOnPassword next;
        public bool CharactersOnPassword(string password)
        {
            string digitCharacter = new DigitCharacter().GetCharacter();

            for (int i = 0; i < password.Length ; i++)
            {
                digitCharacter.Contains(password[i]);
            }
            if (next != null)
            {
                next.CharactersOnPassword(password);
            }
              

            return false;
        }

        public void Next(IVerifyCharacterOnPassword next)
        {
            this.next = next;
        }
    }
}
