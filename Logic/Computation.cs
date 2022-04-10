using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCBackEndAccountAssignment.Logic
{
    public static class Computation
    {
        public static decimal ComputeInterest(int months, decimal interestRate)
        {
            return months * interestRate;
        }
    }
}
