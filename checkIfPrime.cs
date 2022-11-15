using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekTwoTasks
{
    public class checkIfPrime
    {
        public void isItaPrime()
        {
            int n, a, m = 0, primeIndicator = 0;
            Console.Write("Enter a number to check for primality: \n");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for(a=2; a<=m; a++)
            {
                if(n%a == 0)
                {
                    Console.Write($"The Entered Number -> \'{n}\' is Not A Prime");
                    primeIndicator = 1;
                    break;
                }
            }
            if(primeIndicator == 0)
            {
                Console.Write($"The Entered Number -> \'{n}\' Is A Prime");
            }

        }
    }
}
