using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2_Review
{
    public static class Tasks
    {
        public static void BirthDate()
        {
            Console.WriteLine("Please enter your birth year: ");
            int BirthYear = int.Parse(Console.ReadLine());

            for (int i = BirthYear; i <= DateTime.Now.Year; i++)
            {
                Console.WriteLine(i);                
            }
        }

        public static void SquaresSum()
        {
            Console.WriteLine("Please enter a number N: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                //Console.WriteLine($"{ i}  = { i* i}");
                 int square = i*i;
                Console.WriteLine("{0} = {1}", i, square);
                sum += square ;
            }
            Console.WriteLine("Sum = {0}", sum);
        }

        public static void SumAverageN()
        {
            Console.Write("How many numbers will you enter? ");
            int frequency = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int number;
            int sum = 0;            
            
            for (int i = 1; i <= frequency; i++)
            {
                Console.WriteLine("Please enter a number: ");
                number = int.Parse(Console.ReadLine());
                //Console.WriteLine($"N{i} = {number}");
                sum += number;                
            }
            
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", (double)sum / frequency);            
        }

        public static void SumAverageN2()
        {
            //bool finish = false;
            int N = 0;
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Please enter a number, or 'stop' to finish: ");
                string input = Console.ReadLine();

                if (input.Equals("stop", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                int number = int.Parse(input);

                sum += number;
                N++;
            }
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", (double)sum / N);
        }

        public static void SquareHashes()
        {
            Console.Write("Please enter a number N: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }

        public static void Triangle()
        {
            Console.Write("Please enter a number N: ");
            int N = int.Parse(Console.ReadLine());

            for (int line = 1; line <= N; line++)
            {
                for (int row = 1; row <= line; row++)
                {
                    Console.Write(row);
                }
                Console.WriteLine();
            }
        }

        public static void ExampleArray()
        {//different ways of initializing an array
            int[] numbers = new int[3];
            numbers[0] = 5;
            numbers[1] = 3;
            numbers[2] = 78;

            int[] numbers2 = new int[] { 5, 3, 78 };
            int[] numbers3 = { 5, 3, 78 };
        }

        public static void CheckArray()
        {
            int[] array = new int[] { 0, 10, 20, 30, 40, 50 };
            Console.WriteLine("Please, enter a number N: ");
            int N = int.Parse(Console.ReadLine());
            //int counter = 0;
            bool isNumberFound = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == N)
                {
                    Console.WriteLine("Number is found at position {0}!", i);
                    //counter++;
                    isNumberFound = true;
                    break;
                }
            }
            //if(counter == 0){}
            if (!isNumberFound)
            {
                Console.WriteLine("This number is not found in the array!");
            }
            /*
            foreach (int number in array)
            {
                if (number == N)
                {
                    Console.WriteLine("Number is found");
                    break;
                }
            }
            */

            //built-in method
            /*
            bool isNumberinArray = array.Contains(N);
            if (isNumberinArray)
            {
                Console.WriteLine("Number is found in the array!");
            }
            else
            {
                Console.WriteLine("Number is not in the array!");
            }
            */
        }
        public static void InputReverse()
        {
            //int[] numbers = new int[int.MaxValue]; better to use List
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.Write("Please enter a number (0 to stop): ");
                int N = int.Parse(Console.ReadLine());
                
                    if (N == 0)
                    {
                        break;
                    }
                numbers.Add(N);
            }

            //I way of recording it backwards:
            for (int i = numbers.Count-1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);                
            }

            //2nd version of doing the above:
            numbers = numbers.OrderByDescending(n => n).ToList();
            foreach (int num in numbers)
            {
                Console.Write(num);
            }
            

        }
    }
}
