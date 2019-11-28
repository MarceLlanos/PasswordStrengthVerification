using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class CreatorCompositeVerifier : ICreatorCompositeVerifier
    {
        public List<VerifyCharacterOnPassword> CreateVerifier()
        {
            var listCreator = new List<VerifyCharacterOnPassword>();

            var digitCharacter = new DigitCharacter().GetCharacter();
            var specialCharacter = new SpecialCharacter().GetCharacter();
            var lowerAndUpperCharacter = new LowerAndUpperCharacters().GetCharacter();
            // var digitCharacter = new DigitCharacter();

            listCreator.Add(new VerifyCharacterOnPassword(digitCharacter));
            listCreator.Add(new VerifyCharacterOnPassword(specialCharacter));
            listCreator.Add(new VerifyCharacterOnPassword(lowerAndUpperCharacter));

            // var digitVerify = new VerifyCharacterOnPassword(digitCharacter);

            
            return listCreator;
        }
    }
}
