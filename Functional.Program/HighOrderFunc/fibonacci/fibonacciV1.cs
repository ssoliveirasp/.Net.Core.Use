using System;

namespace Functional.Program.Fibonacci
{
    public static class FibonacciV1
    {
        public static void run()
        {
            var f30 = Fibonacci(30);
            var f35 = Fibonacci(35);
            var f40 = Fibonacci(40);

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