﻿namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hi, {name}, on {currentDate:d} at {currentDate:t}");
            Console.Write($"{Environment.NewLine}Press any key to exit");
            Console.ReadKey(true);
        }
    }
}