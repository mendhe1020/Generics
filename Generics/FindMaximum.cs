using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMaximum
    {
        public int FindMaxIntNumber(int firstNum,int secondNum,int thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
                return firstNum;
            if(secondNum.CompareTo(firstNum)>0 && secondNum.CompareTo(thirdNum)>0)
                return secondNum;
            else
                return thirdNum;
        }
    }
}
