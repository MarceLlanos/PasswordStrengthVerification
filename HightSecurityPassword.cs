using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class HightSecurityPassword : ILevelSecurityPassword
    {
        ILevelSecurityPassword nextLevel;
       
        
        public bool LevelSecurity(string password)
        {
            if (password.Length >= 20)
            {
                return  true;
            }

            return false;
        }

        public void NextLevel(ILevelSecurityPassword nextLevel)
        {
            this.nextLevel = nextLevel;
        }
    }
}
