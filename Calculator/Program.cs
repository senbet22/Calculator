// Calculator App!

using Calculator;

Operations operations = new Operations();
InputHelper inputHelper = new InputHelper();


Console.WriteLine("-_-_-_ C# Calculator _-_-_-");
Console.WriteLine("Type 'x' to exit App.\n");

while (true)
{
    string? opInput = inputHelper.AskOperation();

    if (opInput == "x") break;

    if (opInput is not ("1" or "2" or "3" or "4"))
    {
        Console.WriteLine("Invalid choice. Please try again.\n");
        continue;
    }

    if (!inputHelper.TryAskNumbers(out double a, out double b))
    {
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

