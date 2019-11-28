using System.Linq;

namespace PasswordStrenghVerification
{
    class VerifyCharacterOnPassword : IVerifyCharacterOnPassword
    {
        string character;

        public VerifyCharacterOnPassword(string character)
        {
            this.character = character;
        }

        public int CharactersOnPassword(string password)
        {
            int result = 0;

            foreach (var item in password)
            {
                if (character.Contains(item))
                {
                    result = 1;
                }
            }

            return result;
        }        
    }
}
