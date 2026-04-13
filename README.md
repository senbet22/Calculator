# C# Calculator
 
A console-based calculator app built with .NET 10.
 ### Program runs inside (while) loop until user types `x` to exit.

## Features
 
- Add, subtract, multiply, and divide
- Two modes: two numbers or multiple numbers
- Input validation with error handling
- Runs in a loop until the user exits
 
## Project Structure
 
- `Operations.cs` — math methods (Contains two number overloads and `List` overloads
- `InputHelper.cs` — console input and parsing
- `Program.cs` — app flow
 
## Run
 
```bash
dotnet run
```

---
 
## Flowchart
 
```
User picks operation (1-4)
        │
        ├── invalid → loop back
        │
User picks mode (1 = two numbers, 2 = multiple)
        │
        ├── mode 1 → asks for a, b → two-number overload
        ├── mode 2 → asks for a list → list overload
        └── invalid → loop back
        │
    Print result → loop back
```
 
---
 
## Pseudocode
 
Ask the user to pick an operation. If the input is not 1, 2, 3, or 4, show an error and ask again.
 
Ask the user to pick a mode — two numbers or multiple numbers. If the input is not 1 or 2, show an error and ask again.
 
If mode is 1, ask for two numbers one at a time. If either input is not a valid number, show an error and start over.
 
If mode is 2, ask for all numbers in one line separated by commas. If any part is not a valid number, show an error and start over.
 
Run the chosen operation on the numbers. If the user tries to divide by zero, show an error instead of crashing.
 
Show the result and start over.
 
