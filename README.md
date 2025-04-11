# c-sharp-handson
# CSharpCore - Learning C# Fundamentals

This repository contains C# code examples demonstrating fundamental concepts of the C# programming language. It's designed for individuals who are new to C# or looking to solidify their understanding of its core features.

## Table of Contents

- [Overview](#overview)
- [Concepts Covered](#concepts-covered)
- [How to Use](#how-to-use)
- [Code Structure](#code-structure)
- [Contributing](#contributing)
- [License](#license)

## Overview

This project aims to provide clear and concise examples for various basic C# concepts. Each section in the `Core.cs` file focuses on a specific feature, making it easy to understand and experiment with individual topics. The code is heavily commented (now in English!) to explain the purpose and functionality of each example.

## Concepts Covered

The `Core.cs` file covers the following fundamental C# concepts:

- **Basic Output:** Demonstrating `Console.WriteLine()` and formatted output with `Console.Write()`.
- **Nullable Types:** Understanding how value types can hold null values using `?` and `Nullable<T>`.
- **`var` and `dynamic` Keywords:** Exploring implicit type inference (`var`) and runtime type determination (`dynamic`).
- **Input Data:** Reading data from the console using `Console.ReadLine()` and `Convert.ToInt32()`, `float.Parse()`, `double.TryParse()`.
- **Mathematics Operators:** Basic arithmetic operators (`+`, `-`, `*`, `/`, `%`) and `Math` class methods (`Sqrt()`, `Pow()`).
- **Comparison Operators:** Evaluating conditions using `>`, `>=`, `<`, `<=`, `==`, `!=`.
- **Logical Operators:** Combining boolean expressions with `&&`, `||`, `!`.
- **Bitwise Logical Operators:** Performing bit-level operations with `&`, `|`, `^`, `~`, `<<`, `>>`.
- **`if-else` Condition:** Implementing conditional logic.
- **`switch-case` Condition:** Using switch statements for multi-way branching.
- **`while` Loop:** Executing code repeatedly based on a condition.
- **`do-while` Loop:** Similar to `while`, but the loop body executes at least once.
- **`break` Condition:** Exiting a loop prematurely.
- **`continue` Condition:** Skipping the current iteration of a loop.
- **Arrays (1D, 2D, Jagged):** Working with single-dimensional, multi-dimensional, and jagged arrays.
- **`Array` Class:** Utilizing methods of the `System.Array` class.
- **`out` and `ref` Keywords:** Understanding how to pass parameters by reference.
- **`params` Keyword:** Passing a variable number of arguments to a method.
- **More Primitive Data Types:** Examples for `char`, `string`, and `decimal`.
- **Type Casting:** Demonstrating implicit and explicit type conversions.
- **Constants:** Declaring and using constant values with the `const` keyword.
- **Short Assignment Operators:** Using shorthand assignment operators like `+=`, `-=`, etc.
- **`for` and `foreach` Loops:** Iterating through collections and using the basic `for` loop with different variations.
- **More String Manipulation:** Basic operations on strings like `Length`, `ToUpper()`, `ToLower()`, `Substring()`, `IndexOf()`, `Split()`, `Join()`.
- **More `Math` Class Examples:** Using methods like `Round()`, `Ceiling()`, `Floor()`, `Abs()`.
- **Enums (Enumerations):** Defining and using enumerated types.
- **Structs (Structures):** Defining and using value type structures.
- **Namespaces:** Understanding the purpose of namespaces for code organization.

## How to Use

1.  **Clone the Repository:**
    ```bash
    git clone <repository_url>
    cd CSharpCore
    ```
    (Replace `<repository_url>` with the actual URL of your repository.)

2.  **Open with Visual Studio or .NET CLI:**
    * **Visual Studio:** Open the `CSharpCore.sln` file.
    * **.NET CLI:** Navigate to the `CSharpCore` directory in your terminal.

3.  **Run the Code:**
    * **Visual Studio:** Press `Ctrl + F5` (Start Without Debugging) to run the `Core.cs` file.
    * **.NET CLI:** Execute the following command:
        ```bash
        dotnet run
        ```

4.  **Explore the Output:** The console output will demonstrate the results of each example. You can uncomment different sections in the `Main` method of the `Core.cs` file to focus on specific concepts.

## Code Structure

The main logic resides in the `Core.cs` file within the `CSharpCore` namespace. The `Main` method contains commented-out calls to various private static methods, each dedicated to illustrating a particular C# feature. To explore a specific concept, simply uncomment the corresponding method call in the `Main` method and run the application.

```csharp
namespace CSharpCore
{
    class Core
    {
        static void Main(string[] args)
        {
            // Uncomment the function calls below to explore specific concepts

            // ShowInfo();
            // Nullable();
            // VarExample();
            // DynamicExample();
            // InputDataExample();
            // MathematicsOperatorsExample();
            // ... and so on for other examples
            ParamExample(); // Example of params keyword is currently active
        }

        // Each private static method demonstrates a specific C# concept
        private static void ShowInfo() { ... }
        private static void NullableExample() { ... }
        private static void VarExample() { ... }
        // ... other example methods
        private static void ParamExample() { ... }
    }
}
