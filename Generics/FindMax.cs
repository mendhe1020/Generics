using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMax<T> where T:IComparable 
    {
        public T first, second, third;
        public FindMax(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public T FindMaxmum()
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                return first;
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
                return second;
            else
                return third;
        }
    }
}
