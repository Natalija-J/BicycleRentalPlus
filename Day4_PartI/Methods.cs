using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_PartI
{
    class Methods
    {
        public static void CheckLastDigit(int x, int y)
        {
            // task1(1, 21)->SAME
            //   task1(5, 6372)->NOT SAME
            if (x == y)
            {
                Console.WriteLine("-> SAME");
            }
            int xLength = x.ToString().Length;
            char lastDigit = x.ToString()[xLength - 1];
            int yLength = y.ToString().Length;
            int LastYDigit = y.ToString()[yLength - 1];
            if (lastDigit == LastYDigit)
            {
                Console.WriteLine("-> SAME");
            }
            else
            {
                Console.WriteLine("-> NOT SAME");
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
            Console.WriteLine(counter);
        }

        //task3(“wall”)-> 0
        //task3(“Eel”)-> 2
        public static void TaskThree()
        {
            Console.WriteLine("Please enter a word: ");
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
                Console.Write("Please enter a number (or 'stop' to quit): ");
                string input = Console.ReadLine().ToLower();
                if (input == "stop")
                {
                    stop = true;
                    break;
                }
                int num = int.Parse(input);
                enteredN.Add(num);
            }

            int length = enteredN.Count;

            if (enteredN[0] == enteredN[length - 1])
            {
                Console.WriteLine("EQUAL");
            }
            else
            {
                Console.WriteLine(" NOT EQUAL");
            }
        }
        //task5(18, 22)-> 18
        //task5(20, 21)-> 21
        //task5(20, 20)-> 0
        public static void TaskFive()
        {
            Console.WriteLine("Please enter two numbers. Number1: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Number2: ");
            int secondNum = int.Parse(Console.ReadLine());

            if (firstNum == secondNum)
            {
                Console.WriteLine("0");
            }
            //.... do not know how to check that the number is close to 21

            for (int i = 0; i <= 21; i++)
            {
                
            }
        }
    }
}
