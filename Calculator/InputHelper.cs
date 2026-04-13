using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class InputHelper
    {
        public string? AskOperation()
        {
            Console.WriteLine("Choose Operation:");
            Console.WriteLine(" 1 = Addition");
            Console.WriteLine(" 2 = Subtraction");
            Console.WriteLine(" 3 = Multiplication");
            Console.WriteLine(" 4 = Division");
            Console.Write("\nOperation: ");
            return Console.ReadLine() ?? string.Empty;
        }
    }
}