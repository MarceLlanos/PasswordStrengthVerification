using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class DigitCharacter : ICharacteres
    {
        public string GetCharacter()
        {
            return "0123456789";
        }
    }
}
