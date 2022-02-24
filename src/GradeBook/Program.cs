using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {

        static void Main(string[] args)
        {
            var book = new Book("Milvios'book");

            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Caught an expception");
                    throw;
                }
                 catch (FormatException ex)
                {
                    Console.WriteLine("Caught an expception");
                    throw;
                }
                finally
                {
                   Console.WriteLine("*******");
                }

            }

            var stats = book.GetStatistic();

            Console.WriteLine($"lowest grade = {stats.Low}");
            Console.WriteLine($"highest grade = {stats.High}");
            Console.WriteLine(stats.Average);
            Console.Write($"the letter grade is {stats.Letter}");

        }
    }
}

// See https://aka.ms/new-console-template for more information
