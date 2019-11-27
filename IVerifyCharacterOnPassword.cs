using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    interface IVerifyCharacterOnPassword
    {
        int CharactersOnPassword(string password);
    }
}
