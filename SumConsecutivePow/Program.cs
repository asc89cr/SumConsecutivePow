using System;
using System.Collections.Generic;

namespace SumConsecutivePow
{
    class Program
    {
        static void Main(string[] args)
        {
            SumDigPow(1,10000);
        }

        public static long[] SumDigPow(long a, long b)
        {
            List<long> eureka = new List<long>();
            List<long> digits;
            long sum = 0;
            long acumulator = 0;

            for (long i = a; i <= b; i++)
            {
                sum = 0;
                digits = new List<long>();
                acumulator = i;
                long currentPow = 1;

                if (i <= 9 && i > 0)
                {
                    eureka.Add(i);
                }
                else if (i == 10)
                {
                    continue;
                }
                else
                {
                    while (acumulator != 0)
                    {
                        for (int y = 0; y < i.ToString().Length; y++)
                        {
                            digits.Add(acumulator % 10);
                            acumulator = acumulator / 10;
                        }
                    }

                    digits.Reverse();

                    for (int x = 0; x < digits.Count; x++)
                    {
                        sum += (long)Math.Pow(digits[x], currentPow);
                        currentPow++;
                    }

                    if (sum == i)
                        eureka.Add(sum);
                }
            }

            return eureka.ToArray();
        }
    }
}
