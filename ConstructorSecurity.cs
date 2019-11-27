using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class ConstructorSecurity : IConstructorSecurity
    {
       
        public SecurityPassword SecurityConstruct()
        {
            var rangeHighSecurity = new Range(20, 50);
            var rangeEnoughSecurity = new Range(15, 20);
            var rangeNormalSecurity = new Range(10, 15);
            var rangeLowSecurity = new Range(6, 10);

           
            var highSecurity = new SecurityPassword(rangeHighSecurity, 0);
            var enoughSecurity = new SecurityPassword(rangeEnoughSecurity, 1);
            var normlaSecurity = new SecurityPassword(rangeNormalSecurity, 2);
            var lowSecurity= new SecurityPassword(rangeLowSecurity, 3);

            highSecurity.Next(enoughSecurity);
            enoughSecurity.Next(normlaSecurity);
            normlaSecurity.Next(lowSecurity);

            return highSecurity;

        }
    }
}
