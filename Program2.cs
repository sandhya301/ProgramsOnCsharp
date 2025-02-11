using System;
using System.Collections.Generic;
using System.Linq;

namespace Programs
{
    class Program2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the list of integers (separated by spaces):");

            // Read user input, split by spaces, and convert to a list of integers
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            // --- Find numbers greater than 50 ---
            // Using method syntax
            var findNum = numbers.Where(num => num > 50).ToList();

            // Using query syntax (alternative)
            // var findNum = (from num in numbers
            //                where num > 50
            //                select num).ToList();

            Console.WriteLine("\nNumbers greater than 50:");
            Console.WriteLine(string.Join(",", findNum));

            // --- Sort numbers in ascending order ---
            // Using method syntax
            var sortAsc = numbers.OrderBy(num => num).ToList();

            // Using query syntax (alternative)
            // var sortAsc = (from num in numbers
            //                orderby num
            //                select num).ToList();

            Console.WriteLine("\nSorted numbers:");
            Console.WriteLine(string.Join(",", sortAsc));

            // --- Find the square of each number ---
            // Using method syntax
            var square = numbers.Select(num => num * num).ToList();

            // Using query syntax (alternative)
            // var square = (from num in numbers
            //               select num * num).ToList();

            Console.WriteLine("\nSquares of the numbers:");
            Console.WriteLine(string.Join(",", square));
        }
    }
}
