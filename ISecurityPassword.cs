﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    interface ISecurityPassword
    {
        bool IsAtSecureLevel(string password);
        void Next(SecurityPassword next);
    }
}
