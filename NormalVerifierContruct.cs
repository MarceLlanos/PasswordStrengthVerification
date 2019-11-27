﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class NormalVerifierContruct : IVerifyConstructor
    {
        IVerifyCharacter digit = new VerifyDigitCharacters();
        IVerifyCharacter special = new VerifySpecialCharacters();
        IVerifyCharacter lowerUpper = new VerifyLowerUpperCharacters();

        public bool contructVerify(string password)
        {
            string digitResult = digit.CharactersOnPassword(password);
            string specialResult = special.CharactersOnPassword(password);
            string lowerUpperResult = lowerUpper.CharactersOnPassword(password);

            if (digitResult != "" && specialResult != "")
            {
                return true;
            }
            else if (digitResult != "" && lowerUpperResult != "")
            {
                return true;
            }
            return false;
        }
    }
}
