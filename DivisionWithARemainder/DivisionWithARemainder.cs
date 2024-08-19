using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DivisionWithARemainder
{
    public class DivisionWithARemainder
    {
        public static string CheckEvenOrOdd(int input)
        {
            int remainder = input % 2;
            if (remainder == 0)
            {
                return "The number is even.";
            }
            else
            {
                return "The number is odd.";
            }
            
        }
    }
}
