using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class CompositeCharactersVerifer:IVerifyCharacterOnPassword
    {
        List<IVerifyCharacterOnPassword> list;
        public CompositeCharactersVerifer()
        {
            list = new List<IVerifyCharacterOnPassword>();
        }

        public void AddVerifierList(string password)
        {

            list.Add(new VerifyDigitCharactersOnPassword());
            list.Add(new VerifySpecialCharactersOnPassword());
            list.Add(new VerifyLowerUpperCharactersOnPassword());
            
        }

        public int CharactersOnPassword(string password)
        {
            int result = 0;
            foreach (var item in list)
            {
                result = item.CharactersOnPassword(password) == 1? result += 1: result = 0;
            }
            return result;
        }

       
    }
}
