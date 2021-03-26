using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day4_PartI
{
    class Methods
    {
        public static void CheckLastDigit(int x, int y)
        {
            // task1(1, 21)->SAME
            //   task1(5, 6372)->NOT SAME

            /*
            int xLength = x.ToString().Length;
            int yLength = y.ToString().Length;
            char lastDigit = x.ToString()[xLength - 1]; 
            char lastYDigit = y.ToString()[yLength - 1];
            //int lastDigit = xLength - 1; --- checking if length is the same
            //int lastYDigit = yLength - 1;
            if (x == y)
            {
                Console.WriteLine($"Task1({x}, {y}) -> are the SAME numbers");
            }

            else if(lastDigit == lastYDigit)
            {
                Console.WriteLine($"Task1({x}, {y}) -> end in the SAME digit");
            }
            else
            {
                Console.WriteLine($"Task1({x}, {y}) -> Do NOT end in the SAME digit");
            }
            */

            int lastDigit = x % 10;
            int lastYDigit = y % 10;

            if (x % 10 == y % 10)
            {
                Console.WriteLine($"Task1({x}, {y}) -> end in the SAME digit");
            }
            else
            {
                Console.WriteLine($"Task1({x}, {y}) -> Do NOT end in the SAME digit");
            }
        }

        //task2(4)-> 0
        //task2(22)-> 4
        public static void TaskTwo()
        {
            int counter = 0;
            Console.WriteLine("Please enter a number N: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                if ((i + 1) % 5 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"T2: There are {counter} numbers from 1 to {number} that are divisible by 5 ");
        }

        //task3(“wall”)-> 0
        //task3(“Eel”)-> 2
        public static void TaskThree()
        {
            Console.WriteLine("T3: Please enter a word: ");
            string word = Console.ReadLine().ToLower();
            int count = 0;
            char charToCount = 'e';
            foreach (char e in word)
            {
                if (e == charToCount)
                {
                    count++;
                }
            }
            Console.WriteLine($"{word} -> letter 'e' appears { count} times.");
        }
        //task4(9, 1, 9, stop)->EQUAL
        //task4(1, 54, 1, 21, stop)->NOT EQUAL
        public static void TaskFour()
        {
            List<int> enteredN = new List<int>();
            bool stop = false;
            while (!stop)
            {
                Console.Write("T4: Please enter a number (or 'stop' to quit): ");
                string input = Console.ReadLine().ToLower();
                if (input == "stop")
                {
                    stop = true;
                    break;
                }
                int num = int.Parse(input);
                enteredN.Add(num);
            }

            //int length = enteredN.Count;

            //if (enteredN[0] == enteredN[length - 1])
            //{
            //    Console.WriteLine("The first entered number is EQUAL to the last one.");
            //}
            //else
            //{
            //    Console.WriteLine("The first entered number is NOT EQUAL to the last one.");
            //}

            //use LINQ
            //check that the list is not empty 
            if (enteredN.Count > 0 )
            {
                int first = enteredN.First();
                int last = enteredN.Last();
                if (first == last)
                {
                    Console.WriteLine("The first entered number is EQUAL to the last one.");
                }
                else
                {
                    Console.WriteLine("The first entered number is NOT EQUAL to the last one.");
                }
            }
            else
            {
                Console.WriteLine("Numbers were not entered.");
            }
        }
        //task5(18, 22)-> 18
        //task5(20, 21)-> 21
        //task5(20, 20)-> 0
        public static void TaskFive()
        {
            Console.WriteLine("T5: Please enter two numbers. Number1: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Number2: ");
            int secondNum = int.Parse(Console.ReadLine());

            if (firstNum == secondNum)
            {
                Console.WriteLine($"Task5({firstNum}, {secondNum}) -> 0");
            }

            else if (firstNum > 21 && secondNum > 21)
            {
                Console.WriteLine($"({firstNum}, {secondNum}) -> 0");
            }
            else if (firstNum > 21 || secondNum < 21)
            {
                Console.WriteLine($"({firstNum}, {secondNum}) -> {secondNum}");
            }
            else if (firstNum < 21 || secondNum > 21)
            {
                Console.WriteLine($"({firstNum}, {secondNum}) -> {firstNum}");
            }
            else if (firstNum > secondNum && firstNum < 21)
            {
                Console.WriteLine($"({firstNum}, {secondNum}) -> {firstNum}");
            }
            else 
            {
                Console.WriteLine($"({firstNum}, {secondNum}) -> {secondNum}");
            }
            //If num1 is over 21 and num2 is over 21->print out 0
            //If just num1 is over 21->print out num2
            //If just num2 is over 21->print out num1
            //If num1 is equal to num2->print out 0
            //If num1 is greater then num2->print out num1
            //Otherwise->print out num2

        }

        public static void SumNumbers(int number)
        {
                        
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;                
            }
            Console.WriteLine("Sum of all digits = {0}", sum);
        }
    }
}
