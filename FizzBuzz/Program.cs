using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            for (int i = 1; i <= 300; i++)
            {
                Console.WriteLine(fizzBuzz.FizzBuzzFor(i));
            }
        }
    }
}