using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    interface IVerifyCharacterOnPassword
    {
        bool CharactersOnPassword(string password);
        void Next(IVerifyCharacterOnPassword next);
    }
}
