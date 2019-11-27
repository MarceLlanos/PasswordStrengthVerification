using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class NormalVerifierContruct : IVerifyConstructor
    {
        IVerifyCharacterOnPassword digit = new VerifyDigitCharactersOnPassword();
        IVerifyCharacterOnPassword special = new VerifySpecialCharactersOnPassword();
        IVerifyCharacterOnPassword lowerUpper = new VerifyLowerUpperCharactersOnPassword();

        public bool contructVerify(string password)
        {
            bool digitResult = digit.CharactersOnPassword(password);
            bool specialResult = special.CharactersOnPassword(password);
            bool lowerUpperResult = lowerUpper.CharactersOnPassword(password);

            digit.Next(special);
            special.Next(lowerUpper);

            if (digitResult != false && specialResult != false)
            {
                return true;
            }
            else if (digitResult != false && lowerUpperResult != false)
            {
                return true;
            }
            return false;
        }
    }
}
