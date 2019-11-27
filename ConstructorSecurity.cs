using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class ConstructorSecurity : ISecurityConstructor
    {
       
        public SecurityPassword SecurityConstruct()
        {
            Range range = new Range(0,0);
            Range rangeHighSecurity = new Range(20, 50);
            Range rangeEnoughSecurity = new Range(15, 20);
            Range rangeNormalSecurity = new Range(10, 15);
            Range rangeLowSecurity = new Range(6, 10);

            switch (range.GetMin())
            {
                case 20:
                    return new SecurityPassword(rangeHighSecurity, 0);
                case 15: 
                    return new SecurityPassword(rangeEnoughSecurity, 1);
                case 10:
                    return new SecurityPassword(rangeNormalSecurity, 2);
                case 6:
                    return new SecurityPassword(rangeLowSecurity, 3);
                default:
                    return new SecurityPassword(rangeLowSecurity, 3);

            }
        }
    }
}
