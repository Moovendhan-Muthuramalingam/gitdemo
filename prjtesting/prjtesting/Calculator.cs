using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjtesting
{
    class Calculator
    {
       
        public int Addition (dynamic a,dynamic b)
        {
            return a + b;   
        }

        public int Subtraction (dynamic a,dynamic b)
        {
            if (a < b)
                throw new ArgumentException("a is < than b");
            return a - b;
        }

        public bool PstInt(dynamic a, dynamic b)
        {
            if (a > 0 )
                return true;
            
        }
    }
}
