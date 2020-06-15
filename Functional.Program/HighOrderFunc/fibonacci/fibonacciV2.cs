using System;

namespace Functional.Program.Fibonacci
{
    public static class FibonacciV2
    {
        public static void run()
        {
           Func<int, int> fibo = (n) => {
                var result = Fibonacci(n);
                Console.WriteLine($"Result for {n} is {result}");
                return result;
           };

            var f30 = fibo(30);
            var f35 = fibo(35);
            var f40 = fibo(40);

            Console.WriteLine($"Results: {f30}, {f35}, {f40}");
        }

        private static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

}