using System;
using System.Collections.Generic;

namespace GradeBook
{

class Program {

 static void Main(string[] args)
 {

    var book = new Book("Milvios'book");
    book.AddGrade(2);
    book.AddGrade(5);
    book.AddGrade(7);
    var stats =  book.GetStatistic();

    
 Console.WriteLine($"lowest grade = {stats.Low}");
  Console.WriteLine($"highest grade = {stats.High}");
 Console.WriteLine(stats.Average);

}
}
}

// See https://aka.ms/new-console-template for more information
