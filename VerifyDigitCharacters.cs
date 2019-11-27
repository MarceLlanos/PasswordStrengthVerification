using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class VerifyDigitCharacters : IVerifyCharacter
    {
        IVerifyCharacter next;
        public string CharactersOnPassword(string password)
        {
            StringBuilder passwordBuilder = new StringBuilder(password);
            var characteres = new DigitCharacter().GetCharacter();

            foreach (var item in characteres)
            {
                if (passwordBuilder.Equals(item))
                {
                    return "0";
                }
                if (next != null)
                {
                    next.CharactersOnPassword(password);
                }
               
            }

            return string.Empty;
        }

        public void Next(IVerifyCharacter next)
        {
            this.next = next;
        }
    }
}
