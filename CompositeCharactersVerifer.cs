using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class CompositeCharactersVerifer:IVerifyCharacterOnPassword
    {
        ICreatorCompositeVerifier listCreator;

        public CompositeCharactersVerifer()
        {
            listCreator = new CreatorCompositeVerifier();
           
        }


        public int CharactersOnPassword(string password)
        {
            int result = 0;
            var listCreatorVerifier = listCreator.CreateVerifier();

            foreach (var item in listCreatorVerifier)
            {
                result += item.CharactersOnPassword(password);
            }

            return result;
        }

       
    }
}
