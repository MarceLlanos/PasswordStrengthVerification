using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class VerifySpecialCharacters: IVerifyCharacter
    {
        IVerifyCharacter next;
        public string CharactersOnPassword(string password)
        {
            var digitCharacter = new SpecialCharacter().GetCharacter();
            StringBuilder passwordBuilder = new StringBuilder(password);

            foreach (var item in digitCharacter)
            {
                if (passwordBuilder.Equals(item))
                {
                    return "_";
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
