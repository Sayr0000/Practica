using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Common
{
    public static class GeneralHelper
    {
        public static void Swap<T>(ref T a, ref T b)
        {T temp = a;
            a = b;
            b = temp;
        }
        public static T Max<T>(T a, T b) where T : IComparable<T>
        {if (a.CompareTo(b) > 0)
            {return a;
            }
            return b;
        }
    }
}
