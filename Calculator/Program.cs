// Calculator App!
// This app runs inside a (while) loop. Press (x) to exit the app.
// App asks for the operation to perform (addition, subtraction, multiplication, division).

using Calculator;

Operations operations = new Operations();
InputHelper inputHelper = new InputHelper();


Console.WriteLine("-_-_-_ C# Calculator _-_-_-");
Console.WriteLine("Type 'x' to exit App.\n");

while (true)
{
    // Ask for the operation to perform.
    string? opInput = inputHelper.AskOperation();

    if (opInput == "x") break;

    if (opInput is not ("1" or "2" or "3" or "4"))
    {
        Console.WriteLine("Invalid choice. Please try again.\n");
        continue;
    }

    Console.Write("Enter two numbers (press 1) or multiple numbers (press 2): ");

    string mode = Console.ReadLine() ?? string.Empty;

    double result = 0;
    
    try
    {
        if (mode == "1")
        {
            if (!inputHelper.TryAskNumbers(out double a, out double b)) continue;

            switch (opInput)
            {
                case "1": result = operations.Add(a, b); break;
                case "2": result = operations.Subtract(a, b); break;
                case "3": result = operations.Multiply(a, b); break;
                case "4": result = operations.Divide(a, b); break;
                default: Console.WriteLine("Invalid choice. Please try again.\n"); continue;
            }
        }
        else if (mode == "2")
        {
            if (!inputHelper.TryAskNumbers(out List<double> numbers)) continue;

            switch (opInput)
            {
                case "1": result = operations.Add(numbers); break;
                case "2": result = operations.Subtract(numbers); break;
                case "3": result = operations.Multiply(numbers); break;
                case "4": result = operations.Divide(numbers); break;
                default: Console.WriteLine("Invalid choice. Please try again.\n"); continue;
            }
        }
        else
        {
            Console.WriteLine("Invalid mode. Please try again.\n");
            continue;
        }

        Console.WriteLine($"Result: {result:F2}\n");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Error: {ex.Message}\n");
    }
}
Console.WriteLine("Goodbye!");
