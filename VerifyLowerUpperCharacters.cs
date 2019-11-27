using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class VerifyLowerUpperCharacters: IVerifyCharacter
    {
        IVerifyCharacter next;
        public string CharactersOnPassword(string password)
        {
            StringBuilder passwordBuilder = new StringBuilder(password);
            var characteres = new LowerUpperCharacter().GetCharacter();

            foreach (var item in characteres)
            {
                if (passwordBuilder.Equals(item))
                {
                    return "a";
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
