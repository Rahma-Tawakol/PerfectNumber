using System;
namespace Perfectnum
{
    public static class Program
    {
        public static int FindFactors(int n2)
        {
            int sum = 0;
            for (int i = 1; i < n2; i++)
            {
                if (n2 % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static void Main()
        {
            Console.WriteLine("please enter n1");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter n2");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n2; i++)
            {
                int result = FindFactors(i);
                if (i > n1)
                {
                    if (i == result)
                    {
                        Console.Write("\t" + i);
                    }
                }
            }
        }
    }
}
