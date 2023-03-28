using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMaximum<T> where T : IComparable
    {
        public static T MaximumIntegertNumber(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue)>0 && firstValue.CompareTo(thirdValue)>0 ||
               firstValue.CompareTo(secondValue)>=0 && firstValue.CompareTo(thirdValue)>0 ||
               firstValue.CompareTo(secondValue)>0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }  

            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }

            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return thirdValue;
            }

            return firstValue;
        }
    }
}
