﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    interface ILevelSecurityPassword
    {
        bool IsAtSecureLevel(string password);
        
        void NextLevel(ILevelSecurityPassword nextLevel);
    }
}
