

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
        public bool TryAskNumbers(out double a, out double b )
        {
            a = 0;
            b = 0;

            Console.Write("First number: ");
            string inputA = Console.ReadLine() ?? string.Empty;
            if (!double.TryParse(inputA, out a))
            {
                Console.WriteLine("Invalid number. Please try again.\n");
                return false;
            }

            Console.Write("Second number: ");
            string inputB = Console.ReadLine() ?? string.Empty;
            if (!double.TryParse(inputB, out b))
            {
                Console.WriteLine("Invalid number. Please try again.\n");
                return false;
            }

            return true;
        }

        public bool TryAskNumbers(out List<double> numbers)
        {
            numbers = [];

            Console.Write("Enter numbers separated by comma (e.g. 4, 7.5, 2): ");
            string rawInput = Console.ReadLine() ?? string.Empty;

            foreach (string part in rawInput.Split(','))
            {
                if (double.TryParse(part.Trim(), out double value))
                {
                    numbers.Add(value);
                }
                else
                {
                    Console.WriteLine($"Invalid number: '{part.Trim()}'. Please try again.\n");
                    return false;
                }
            }

            return numbers.Count > 0;
        }
    }


}