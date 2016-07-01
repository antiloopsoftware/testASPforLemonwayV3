using log4net;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace LemonWayBusinessLogicLayer
{
    public class FibonacciService : IFibonacciService
    {
        public FibonacciService() { }

        long IFibonacciService.getFibonacci(int n)
        {
            if (n < 1 || n > 100)
                return -1;

            /*
             * Code snippet written by Shahin Khorshidnia licensed under The Code Project Open License (CPOL)
             * code source page : http://www.codeproject.com/Articles/142292/Recursive-methods-in-Csharp
             */

            long[] f = new long[n + 1];
            f[0] = 0;
            f[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];
        }
    }
}
