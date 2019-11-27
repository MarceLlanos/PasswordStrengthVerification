using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class EnoughSecurity : ILevelSecurityPassword
    {
        ILevelSecurityPassword nextLevel;
        public bool LevelSecurity(string password)
        {
            
        }

        public void NextLevel(ILevelSecurityPassword nextLevel)
        {
            this.nextLevel = nextLevel;
        }
    }
}
