using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class HighSecurityPassword : ILevelSecurityPassword
    {
        ILevelSecurityPassword nextLevel;
       
        
        public bool IsAtSecureLevel(string password)
        {
            if (password.Length >= 20)
            {
                nextLevel = null;
                return  true;
            }
            if (nextLevel != null)
            {
                return nextLevel.IsAtSecureLevel(password);
            }

            return false;
        }

        public void NextLevel(ILevelSecurityPassword nextLevel)
        {
            this.nextLevel = nextLevel;
        }
    }
}
