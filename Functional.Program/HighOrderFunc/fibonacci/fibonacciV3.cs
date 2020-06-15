using System;

namespace Functional.Program.Fibonacci
{
    public static class FibonacciV3
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

        public static Func<T, TResult> MeasuringTimeOf<T, TResult>(Func<T, TResult> Func) => (input) => {
            var before = DateTime.Now;
            var result = Func(input);
            var totalTime = DateTime.Now - before;

            Console.WriteLine($"Result for {input} is {result}");

            return result;   
        }

        private static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

}