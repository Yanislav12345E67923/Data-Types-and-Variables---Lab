using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;            
            bool ifTrue = false;
            for (int i = 1; i <= n; i++)
            {
                int number = i;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                ifTrue = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, ifTrue);
                sum = 0;                
            }
        }
    }
}

