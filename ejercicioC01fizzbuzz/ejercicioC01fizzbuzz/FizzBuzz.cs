using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioC01fizzbuzz
{
    public static class FizzBuzz
    {
        public static string ImplementarFizzBuzz(this Int32 num)
        {
            if(num % 5 == 0 && num % 3 == 0)
            {
                return "FizzBuzz";
            }
            else if(num%5==0)
            {
                return "Buzz";
            }
            else if(num % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return "";
            }

        }
    }
}
