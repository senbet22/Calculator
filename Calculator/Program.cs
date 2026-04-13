// Calculator App!

using Calculator;

Operations operations = new Operations();



Console.WriteLine("-_-_-_ C# Calculator _-_-_-");
Console.WriteLine("Type 'x' to exit App.\n");

while (true)
{
    Console.WriteLine("Choose Operation:");
    Console.WriteLine(" 1 = Addition");
    Console.WriteLine(" 2 = Subtraction");
    Console.WriteLine(" 3 = Multiplication");
    Console.WriteLine(" 4 = Division");
    Console.Write("\nOperation: ");

    string? opInput = Console.ReadLine() ?? string.Empty;
    if (opInput == "x") break;

    Console.Write("Enter first number: ");
    string inputA = Console.ReadLine() ?? string.Empty;
    if (!double.TryParse(inputA, out double a))
    {
        Console.WriteLine("Invalid number. Please try again.\n");
        continue;
    }

    Console.Write("Enter second number: ");
    string inputB = Console.ReadLine() ?? string.Empty;
    if (!double.TryParse(inputB, out double b))
    {
        Console.WriteLine("Invalid number. Please try again.\n");
        continue;
    }

    double result = 0;

    try
    {
        switch (opInput)
        {
            case "1": result = operations.Add(a, b); break;
            case "2": result = operations.Subtract(a, b); break;
            case "3": result = operations.Multiply(a, b); break;
            case "4": result = operations.Divide(a, b); break;
            default: Console.WriteLine("Invalid choice. Please try again.\n"); continue;
        }

        Console.WriteLine($"Result: {result}\n");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Error: {ex.Message}\n");
    }
}

Console.WriteLine("Goodbye!");

