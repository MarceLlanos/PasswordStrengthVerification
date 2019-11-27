using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrenghVerification
{
    class Range
    {
        int max;
        int min;

        public  Range(int min, int max)
        {
            this.max = max;
            this.min = min;
        }

        public void SetRange(int min, int max)
        {
            this.max = max;
            this.min = min;
        }
    public int GetMin()
        {
            return min;
        }
        public int GetMax()
        {
            return max;
        }
    }
}