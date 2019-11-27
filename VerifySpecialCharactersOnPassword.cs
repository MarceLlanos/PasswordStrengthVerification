using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class VerifySpecialCharactersOnPassword: IVerifyCharacterOnPassword
    {
        IVerifyCharacterOnPassword next;
        public bool CharactersOnPassword(string password)
        {
            string specialCharacter = new SpecialCharacter().GetCharacter();

            for (int i = 0; i < 30; i++)
            {
                if (password[i] == specialCharacter[i])
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
