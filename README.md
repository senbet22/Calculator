# C# Calculator
 
A console-based calculator app built with .NET 10.
 
## Features
 
- Add, subtract, multiply, and divide two numbers
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
 
Type `x` to exit.

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
 
Ask the user to pick an operation and a mode.
 
If mode is 1, ask for two numbers and run the operation on them.
 
If mode is 2, ask for multiple numbers separated by a comma and run the operation on the whole list.
 
Show the result and start over.
 
