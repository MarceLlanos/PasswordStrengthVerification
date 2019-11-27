using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    interface IVerifyCharacter
    {
        string CharactersOnPassword(string password);
        void Next(IVerifyCharacter next);
    }
}
