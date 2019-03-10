using System;
using System.Diagnostics;

namespace AssignmentApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 25;
            printPrimeNumbers(x, y);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);
            Console.ReadLine();

            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);


        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                for (int i = x; i <= y; i++)
                {
                    if (!isPrime(i))
                    {
                        Console.WriteLine(i + " is prime");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception :"+e.Message);
            }
            Console.ReadLine();
        }

        public static bool isPrime(int num)
        {
            bool flag = false;
            for (int i = 2; i <= num / 2; ++i)
            {
                // condition for nonprime number
                if (num % i == 0)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public static double getSeriesResult(int n)
        {
            double output = 0.0;
            try
            {
                int iStart = 1;
                while (iStart <= n)
                {
                    if (iStart%2 != 0)
                    {
                        output = output + (computeFactorial(iStart) / (iStart + 1.0));
                    }
                    else
                    {
                        output = output - (computeFactorial(iStart) / (iStart + 1.0));
                    }
                    iStart++;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()"+e.Message);
            }

            return output;
        }

        public static int computeFactorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return (n * computeFactorial(n - 1));
        }

        public static void printTriangle(int x)
        {
            try
            {
                for (int i = 1; i <= x; i++)
                {
                    //loop to print spaces
                    for (int j = 1; j <= (x - i); j++)
                        Console.Write(" ");

                    //loop to print stars
                    for (int t = 1; t < i * 2; t++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }catch(Exception e)
            {
                Console.WriteLine("Exception occured while computing printTriangle(int x)" + e.Message);
            }
            Console.ReadLine();
        }

        public static void computeFrequency(int[] arr)
        {
            try
            {
                int i = 0;
                int n = arr.Length;
                while (i < n)
                {
                    if (arr[i] <= 0)
                    {
                        i++;
                        continue;
                    }

                    int index = arr[i] - 1;

                    if (arr[index] > 0)
                    {
                        arr[i] = arr[index];
                        arr[index] = -1;
                    }
                    else
                    {
                        arr[index]--;
                        arr[i] = 0;
                        i++;
                    }
                }

                Console.Write("\nNumber	  Frequency" + "\n");
                for (int j = 0; j < n; j++)
                {
                    if (Math.Abs(arr[j]) != 0)
                        Console.Write(j + 1 + "         " + Math.Abs(arr[j]) + "\n");
                }
            }catch(Exception e)
            {
                Console.WriteLine("Exception occured while computing computeFrequency(int[] arr)" + e.Message);
            }
            Console.ReadLine();
        } 

    }
}
