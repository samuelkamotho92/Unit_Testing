using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignments
{
    public class ReverseOrdering
    {
        public int reverseValue(int a)
        {
            int n = a;
            int reverseNum = 0;
                while (n!=0)
                {
                    int dgt = n % 10;
                    reverseNum = reverseNum * 10 + dgt;
                Console.WriteLine(reverseNum);
                    n = n / 10;
                }
            return reverseNum;
        }
    }
}
