using System;

namespace fizzBuzz
{
    //Program initialised
    class Program
    {
        //Main procedure used to run program's main function
        static void Main(string[] args)
        {
            //Using a for loop the program iterates through a loop of values starting with 1 and ending with 100
            for (int i = 1; i <= 100; i++)
            {
                //IF statement which will print the correct output dependant on whether it is divisible by 3, 5, both 3 & 5, or neither of them('Fizz', 'Buzz', 'FizzBuzz', 'number')
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
