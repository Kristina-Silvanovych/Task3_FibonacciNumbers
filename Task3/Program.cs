using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci sequence formula f0=f1=1; fn=fn-1+fn-2 ...
            Console.Write("Input the nth Fibonacci number ");
            int n = Convert.ToInt32(Console.ReadLine());
            //Iterative way
            int itWay = IterativeFibonacci(n);
            Console.WriteLine($"Iterative way to find the nth Fibonacci number: {itWay}\n");

            //Recursive way
            int recWay = RecursiveFibonacci(n);
            Console.WriteLine($"Recursive way to find the nth Fibonacci number: {recWay}");


            Console.ReadKey();
        }

        static int IterativeFibonacci(int n)
        {
            if (n <= 1) return n;

            int f1 = 0, f2 = 1, f3 = 0; //Initialize variables to store Fibonacci numbers
            for (int i = 2; i <= n; i++) //Loop to calculate Fibonacci numbers iteratively
            {
                f3 = f1 + f2; //Update variables for the next iteration
                f1 = f2;
                f2 = f3;
            }

            return f2;
        }

        static int RecursiveFibonacci(int n)
        {
            if (n <= 1) return n;

            return RecursiveFibonacci(n-1) + RecursiveFibonacci(n-2); //Recursive calls to find Fibonacci numbers according to Fibonacci formula
        }

        //Time Complexity:
        //The time complexity of the iterative approach is O(n).
        //The time complexity of the recursive approach is exponential, approximately O(2^n). This is because the recursive approach recalculates the Fibonacci values for the same subproblems multiple times. 
            
        //Space Complexity:
        //The space complexity of the iterative approach is O(1) as it only uses a constant amount of space for variables.
        //The space complexity of the recursive approach is O(n) due to the recursive call stack, which can go up to depth n.
    }
}
