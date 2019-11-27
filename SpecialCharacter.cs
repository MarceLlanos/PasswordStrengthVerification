using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class SpecialCharacter : ICharacteres
    {
        public string GetCharacter()
        {
            return " !#$%&'()*+,-./:;<=>?@['\']^_`{|}~"; 
        }
    }
}
