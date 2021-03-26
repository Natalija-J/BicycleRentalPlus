using Day4_PartI;
using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part I - Basic data manipulation
            //1.Create a program, which checks if two entered numbers ends with the same digit.

            Methods.CheckLastDigit(12,52);
            Methods.CheckLastDigit(13, 13);
            Methods.CheckLastDigit(1, 57);

            Console.WriteLine();
            //2. Create a program where the user enters number N. Output a count of how many
            //numbers from 1 to N is divisible by 5.

            Methods.TaskTwo();
            Console.WriteLine();

            //3. Create a program, which counts how many letters ‘e’ are in the entered word
            //(case-insensitive).
            Methods.TaskThree();
            Console.WriteLine();

            //4. Create a program where the user enters multiple numbers (input is stopped with a
            //keyword ‘stop’). Output a message if the first and the last numbers are equal.
            Methods.TaskFour();
            Console.WriteLine();

            //5. Create a program where the user enters two numbers. Output the number which is
            //closest to 21 and doesn’t exceed 21.Output ‘0’ if both numbers are equal.
            
            Methods.TaskFive();
            Console.ReadLine();

            Methods.SumNumbers(5230424);
        }

        
    }
}
