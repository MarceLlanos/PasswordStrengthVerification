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

            for (int i = 0; i < 33 ; i++)
            {
                if (password[i] == digitCharacter[i])
                {
                    return true;
                }
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
