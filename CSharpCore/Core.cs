using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCore
{
    class Core
    {
        static void Main(string[] args)
        {
            /* Call Function ShowInfo */
            //ShowInfo();

            /* Nullable */
            // Nullable is a concept that allows value types such as int, double, bool, etc., to hold a null value.
            //Nullable();

            /* Var and Dynamic */
            /* var */
            // 'var' is a shorthand way to declare a variable where the compiler automatically infers the type from the assigned value.
            // 'var' can only be used when a variable is initialized at the time of declaration, as the compiler needs to infer the type.
            //VarExample();

            /* 'dynamic' */
            // 'dynamic' allows you to declare a variable whose data type is determined at runtime instead of compile time.
            //DynamicExample();

            /* Input data */
            //InputDataExample();

            /* Mathematics operators */
            // +, -, *, /, %, ++, --, Math.Sqrt(), Math.Pow()
            //MathematicsOperatorsExample();

            /* Comparision Operators */
            // >, >=, <, <=, ==, !=
            // Result: true or false
            //ComparisonOperatorsExample();

            /* Logical Operators */
            // && || !
            //LogicalOperatorsExample();

            /* Bitwise Logical Operators */
            // &, |, ^, ~, <<, >>
            //BitwiseLogicalOperatorsExample();

            /* if-else condition */
            //IfElseConditionExample();

            /* Switch-case condition */
            //SwitchCaseConditionExample();

            /* While loop */
            //WhileLoopExample();

            /* Do-While loop */
            //DoWhileLoopExample();

            /* Break condition */
            //BreakConditionExample();


            /* Continue condition */
            //ContinueConditionExample();

            /* Array 1D */
            //Array1DimensionExample();

            /* Array 2D */
            //Array2DimensionExample();

            /* Jagged Array */
            //JaggedArrayExample();

            /* Array Class */
            //ArrayClassExample();

            /* out and ref keyword */
            /* out keyword được sử dụng khi biến local không mang giá trị nào trước đó */
            /* out keyword được dùng cả ở phần đối số và phần tham số */
            //float a, b;
            //OutKeywordExample(out a, out b);
            //Console.WriteLine("After Input: a = " + a + ", b = " + b);

            /* ref keyword được sử dụng khi biến local đã mang giá trị trước đó */
            //Console.WriteLine("Before Swap: a = " + a + ", b = " + b);
            //RefKeywordExample(ref a, ref b);
            //Console.WriteLine("After Swap: a = " + a + ", b = " + b);

            /* params keyword dùng trong trường hợp truyền đi một danh sách dữ liệu cùng kiểu hoặc một mảng một chiều */
            /* sau đối số params không được có bất cứ tham số nào khác */
            //ParamExample();

            /* More Primitive Data Types */
            //CharExample();
            //StringExample();
            //DecimalExample();

            /* Type Casting */
            //TypeCastingExample();

            /* Constants */
            //ConstantsExample();

            /* Short Assignment Operators */
            //ShortAssignmentOperatorsExample();

            /* For Loop */
            //ForLoopExample();

            /* More String Manipulation */
            //MoreStringManipulationExample();

            /* More Math Class Examples */
            //MoreMathExamples();

            /* Enum Example */
            //EnumExample();

            /* Struct Example */
            //StructExample();

            /* Namespace Explanation */
            //ExplainNamespace();
        }

        private static void ExplainNamespace()
        {
            Console.WriteLine("\n/* Namespace Explanation */");
            Console.WriteLine("// Namespaces help organize your code and prevent naming conflicts.");
            Console.WriteLine("// The 'using System;' statement at the top allows you to use classes from the System namespace");
            Console.WriteLine("// without having to write 'System.' before them (e.g., Console instead of System.Console).");
            Console.WriteLine("// Your code is currently in the 'CSharpCore' namespace.");
        }

        private static void StructExample()
        {
            Console.WriteLine("\n/* Struct Example */");
            Point p1;
            p1.X = 10;
            p1.Y = 20;
            Console.WriteLine($"Point 1: X = {p1.X}, Y = {p1.Y}");
        }
        struct Point
        {
            public int X;
            public int Y;
        }

        private static void EnumExample()
        {
            Console.WriteLine("\n/* Enum Example */");
            Day today = Day.Wednesday;
            Console.WriteLine($"Today is: {today} (value: {(int)today})");
        }
        enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        private static void MoreMathExamples()
        {
            Console.WriteLine("\n/* More Math Class Examples */");
            Console.WriteLine($"Math.Round(3.14159, 2): {Math.Round(3.14159, 2)}");
            Console.WriteLine($"Math.Ceiling(3.2): {Math.Ceiling(3.2)}");
            Console.WriteLine($"Math.Floor(3.8): {Math.Floor(3.8)}");
            Console.WriteLine($"Math.Abs(-5): {Math.Abs(-5)}");
        }

        private static void MoreStringManipulationExample()
        {
            Console.WriteLine("\n/* More String Manipulation */");
            string message = "Hello C# World!";
            Console.WriteLine($"Length: {message.Length}");
            Console.WriteLine($"ToUpper(): {message.ToUpper()}");
            Console.WriteLine($"ToLower(): {message.ToLower()}");
            Console.WriteLine($"Substring(6): {message.Substring(6)}");
            Console.WriteLine($"IndexOf('C'): {message.IndexOf('C')}");
            string[] words = message.Split(' ');
            Console.WriteLine($"Split(' '): {string.Join("-", words)}");
        }
        private static void ForLoopExample()
        {
            Console.WriteLine("\n/* For Loop Example */");

            // Example 1: Basic for loop
            Console.WriteLine("\n// Example 1: Basic for loop");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteration (for): {i}");
            }

            // Example 2: Iterating through an array using a for loop
            Console.WriteLine("\n// Example 2: Iterating through an array using a for loop");
            int[] numbers = { 10, 20, 30, 40, 50 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }

            // Example 3: Iterating through a collection using a foreach loop
            Console.WriteLine("\n// Example 3: Iterating through a collection using a foreach loop");
            foreach (int number in numbers)
            {
                Console.WriteLine($"Number (foreach): {number}");
            }

            // Example 4: Iterating through a List<T> using a foreach loop
            Console.WriteLine("\n// Example 4: Iterating through a List<T> using a foreach loop");
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            foreach (string name in names)
            {
                Console.WriteLine($"Name (foreach): {name}");
            }

            // Example 5: for loop with a different step
            Console.WriteLine("\n// Example 5: for loop with a different step");
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine($"Even number (for with step): {i}");
            }

            // Example 6: for loop iterating in reverse order
            Console.WriteLine("\n// Example 6: for loop iterating in reverse order");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"numbers[{i}] (reverse for) = {numbers[i]}");
            }
        }

        private static void ShortAssignmentOperatorsExample()
        {
            Console.WriteLine("\n/* Short Assignment Operators */");
            int num = 10;
            num += 5; // Equivalent to num = num + 5;
            Console.WriteLine("num += 5: " + num);
            num -= 3; // Equivalent to num = num - 3;
            Console.WriteLine("num -= 3: " + num);
            num *= 2; // Equivalent to num = num * 2;
            Console.WriteLine("num *= 2: " + num);
        }
        private static void ConstantsExample()
        {
            Console.WriteLine("\n/* Constants Example */");
            const double PI = 3.14159;
            Console.WriteLine("Value of PI: " + PI);
            // PI = 3.14; // This would cause a compile-time error
        }
        private static void TypeCastingExample()
        {
            Console.WriteLine("\n/* Type Casting */");
            int intValue = 10;
            long longValue = intValue; // Implicit casting

            double doubleValue = 15.7;
            int anotherIntValue = (int)doubleValue; // Explicit casting (potential loss of precision)
            Console.WriteLine($"Implicit: int {intValue} to long {longValue}");
            Console.WriteLine($"Explicit: double {doubleValue} to int {anotherIntValue}");

            string stringNumber = "123";
            int parsedInt = Convert.ToInt32(stringNumber);
            Console.WriteLine($"Convert.ToInt32: string '{stringNumber}' to int {parsedInt}");
        }
        private static void DecimalExample()
        {
            Console.WriteLine("\n/* Decimal Example */");
            decimal price = 19.99m;
            decimal taxRate = 0.08m;
            decimal total = price * (1 + taxRate);
            Console.WriteLine($"Price: {price}, Tax Rate: {taxRate}, Total: {total}");
        }
        private static void StringExample()
        {
            Console.WriteLine("\n/* String Example */");
            string message = "Hello C#";
            Console.WriteLine(message);
            Console.WriteLine("Length of message: " + message.Length);
            Console.WriteLine("Concatenation: " + message + " World!");
            Console.WriteLine("First character: " + message[0]);
        }
        private static void CharExample()
        {
            Console.WriteLine("\n/* Char Example */");
            char initial = 'P';
            Console.WriteLine("Initial: " + initial);
            char digitChar = '7';
            Console.WriteLine("Is digit? " + char.IsDigit(digitChar));
        }

        private static void ParamExample()
        {
            int sum = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Console.WriteLine("Sum " + sum);
            int[] arr = { 10, 20, 30 };
            Console.WriteLine("Sum array: " + Sum(arr));
        }
        private static int Sum(params int[] li)
        {
            return li.Sum();
        }

        private static void RefKeywordExample(ref float a, ref float b)
        {
            Swap(ref a, ref b);
            Console.WriteLine("After Swap: " + a + " " + b);
        }
        static void Swap(ref float a, ref float b)
        {
            float temp = a;
            a = b;
            b = temp;
        }

        private static void OutKeywordExample(out float a, out float b)
        {
            InputData(out a, out b);
        }
        static void InputData(out float A, out float B)
        {
            Console.Write("Input A: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Input B: ");
            B = float.Parse(Console.ReadLine());

        }

        private static void ArrayClassExample()
        {
            Array arr = Array.CreateInstance(typeof(int), 5);
            for (int i = 0; i < arr.Length; i++)
                arr.SetValue(i * 10, i);
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine($"arr[{i}] = {arr.GetValue(i)}");
        }

        private static void JaggedArrayExample()
        {
            int[][] jaggedArray1 = new int[3][];
            jaggedArray1[0] = new int[] { 1, 2 };
            jaggedArray1[1] = new int[] { 3, 4, 5 };
            jaggedArray1[2] = new int[] { 6 };

            Console.Write("Input row for jagged Array: ");
            int row = int.Parse(Console.ReadLine());
            int[][] jaggedArray2 = new int[row][];

            for (int i = 0; i < row; i++)
            {
                Console.Write($"Input number of elements of row {i + 1}: ");
                int col = int.Parse(Console.ReadLine());
                jaggedArray2[i] = new int[col];

                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Input the {j + 1} element of row {i + 1}: ");
                    jaggedArray2[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.Write($"Sub Array {i + 1}: ");
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.Write(jaggedArray2[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Array2DimensionExample()
        {
            // Method 1
            int[,] array1 = new int[2, 3];

            // Method 2
            int[,] array2;

            // Method 3
            int[,] array3 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    Console.Write($"array[{i},{j}] = ");
                    array3[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    Console.Write(array3[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void Array1DimensionExample()
        {
            Console.Write("Input length of array: ");
            int length = int.Parse(Console.ReadLine());

            // Initialize array with specified length
            int[] arr = new int[length];

            Console.WriteLine("Input data for array: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nArray elements:");
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }

            // Find max value manually
            int max = arr[0];
            for (int i = 1; i < length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }

            Console.WriteLine("Max (manual search) = " + max);
            Console.WriteLine("Sum = " + arr.Sum());
            Console.WriteLine("Max (using LINQ) = " + arr.Max());
            Console.WriteLine("Average = " + arr.Average());

            // Sort and reverse array
            Array.Sort(arr);
            Array.Reverse(arr);

            Console.WriteLine("\nArray after sorting (descending):");
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
        }

        private static void ContinueConditionExample()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        private static void BreakConditionExample()
        {
            char c;
            while (true)
            {
                Console.Write("Input a character: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    c = input[0];
                    Console.WriteLine("You entered: " + c);
                }

                Console.Write("Do you want to continue (Y/N)? ");
                string response = Console.ReadLine();
                if (!string.IsNullOrEmpty(response))
                {
                    char op = response[0];
                    if (op == 'N' || op == 'n')
                    {
                        Console.WriteLine("Bye!");
                        break;
                    }
                }
            }
        }

        private static void DoWhileLoopExample()
        {
            double number;
            do
            {
                Console.Write("Input a number (1-100): ");
                number = double.Parse(Console.ReadLine());
            } while (number < 1 || number > 100);
            Console.WriteLine("Valid number: " + number);

            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 1);
        }

        private static void WhileLoopExample()
        {
            double number;
            Console.Write("Input a number (1-100): ");
            number = double.Parse(Console.ReadLine());
            // while (!(1 <= number && number <= 100))
            // bool isValid = number >= 1 && number <= 100;
            // while (!isValid)
            while (number < 1 || number > 100)
            {
                Console.Write("Re-Input: ");
                number = double.Parse(Console.ReadLine());
            }
            Console.Write("Valid number: " + number);
        }

        private static void SwitchCaseConditionExample()
        {
            int month;
            Console.Write("Input a month: ");
            month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Quarter I");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Quarter II");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Quarter III");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Quarter IV");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
        private static void IfElseConditionExample()
        {
            float avgMark;
            Console.Write("Input avarage mark: ");
            avgMark = float.Parse(Console.ReadLine());

            if (avgMark < 0 || avgMark > 10)
            {
                Console.WriteLine("Invalid");
            }
            else if (avgMark >= 9)
            {
                Console.WriteLine("Excellent");
            }
            else if (avgMark >= 8)
            {
                Console.WriteLine("Distinction");
            }
            else if (avgMark >= 6.5)
            {
                Console.WriteLine("Merit");
            }
            else if (avgMark >= 5)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Refer");
            }
        }
        private static void BitwiseLogicalOperatorsExample()
        {
            int a = 6;  // Binary: 0110
            int b = 3;  // Binary: 0011

            Console.WriteLine("a = " + a + " (binary: 0110)");
            Console.WriteLine("b = " + b + " (binary: 0011)");

            // Bitwise AND
            Console.WriteLine("a & b (AND): " + (a & b)); // 0110 & 0011 = 0010 (2)

            // Bitwise OR
            Console.WriteLine("a | b (OR): " + (a | b)); // 0110 | 0011 = 0111 (7)

            // Bitwise XOR
            Console.WriteLine("a ^ b (XOR): " + (a ^ b)); // 0110 ^ 0011 = 0101 (5)

            // Bitwise NOT
            Console.WriteLine("~a (NOT): " + (~a)); // Inverts all bits, result depends on system (e.g., ~6 = -7)

            // Left shift
            Console.WriteLine("a << 1 (Left shift): " + (a << 1)); // 0110 << 1 = 1100 (12)

            // Right shift
            Console.WriteLine("a >> 1 (Right shift): " + (a >> 1)); // 0110 >> 1 = 0011 (3)
        }
        private static void LogicalOperatorsExample()
        {
            bool x = true;
            bool y = false;

            Console.WriteLine("x = " + x + ", y = " + y);

            // Logical AND
            Console.WriteLine("x && y (AND): " + (x && y)); // True only if both are true

            // Logical OR
            Console.WriteLine("x || y (OR): " + (x || y)); // True if at least one is true

            // Logical NOT
            Console.WriteLine("!x (NOT x): " + (!x)); // Inverts x
            Console.WriteLine("!y (NOT y): " + (!y)); // Inverts y
        }
        private static void ComparisonOperatorsExample()
        {
            int a = 5, b = 10;
            Console.WriteLine("a = " + a + ", b = " + b);

            // Greater than
            Console.WriteLine("a > b: " + (a > b));

            // Less than
            Console.WriteLine("a < b: " + (a < b));

            // Greater than or equal to
            Console.WriteLine("a >= b: " + (a >= b));

            // Less than or equal to
            Console.WriteLine("a <= b: " + (a <= b));

            // Equal to
            Console.WriteLine("a == b: " + (a == b));

            // Not equal to
            Console.WriteLine("a != b: " + (a != b));
        }
        private static void MathematicsOperatorsExample()
        {
            int f = 9, g = 5;
            Console.WriteLine("f = " + f + ", g = " + g);

            // Addition
            Console.WriteLine("Addition: f + g = " + (f + g));

            // Subtraction
            Console.WriteLine("Subtraction: f - g = " + (f - g));

            // Multiplication
            Console.WriteLine("Multiplication: f * g = " + (f * g));

            // Division (float)
            Console.WriteLine("Division (float): f / g = " + ((float)f / g));

            // Integer division
            Console.WriteLine("Division (integer): f / g = " + (f / g));

            // Modulo (remainder)
            Console.WriteLine("Modulo: f % g = " + (f % g));

            // Increment and Decrement
            Console.WriteLine("Increment f: ++f = " + (++f));
            Console.WriteLine("Decrement g: --g = " + (--g));
        }
        private static void InputDataExample()
        {
            int c;
            Console.Write("Input C: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value C = " + c);

            float d;
            Console.Write("Input D: ");
            d = float.Parse(Console.ReadLine());
            Console.WriteLine("Value D = " + d);

            double e;
            Console.Write("Input E: ");
            bool isValid = double.TryParse(Console.ReadLine(), out e);
            if (isValid)
                Console.WriteLine("Value E = " + e);
            else
                Console.WriteLine("Invalid input for E!");
        }
        private static void DynamicExample()
        {
            dynamic something = 123;
            Console.WriteLine(something);
            something = 123.4;
            Console.WriteLine(something);
            something = "C Sharp";
            Console.WriteLine(something);
            something = true;
            Console.WriteLine(something);
        }

        // Demonstrates how to use the 'var' keyword in C# for variable declaration.
        // Includes examples with List, Dictionary, and Array.
        private static void VarExample()
        {
            var numbers = new List<int> { 1, 2, 3, 4 };
            foreach (var num in numbers)
            {
                Console.WriteLine("Number: " + num);
            }

            var capitals = new Dictionary<string, string>
            {
                { "Vietnam", "Hanoi" },
                { "Japan", "Tokyo" }
            };
            foreach (var pair in capitals)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            string[] subjects = { "Math", "Physical", "Chemical" };
            foreach (var subject in subjects)
                Console.WriteLine(subject);
        }
        private static void NullableExample()
        {
            // Example 1: Using int? (nullable int)
            Console.Write("Input a = ");
            string input = Console.ReadLine();

            int? a = null;
            if (int.TryParse(input, out int parsedValue))
            {
                a = parsedValue;
            }

            int b = a ?? -1;
            Console.WriteLine($"a = {a}, b = {b}");

            // Example 2: Using Nullable<T> with built-in value type (int)
            Nullable<int> optionalNumber = null;

            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                optionalNumber = number;
            }

            int finalNumber = optionalNumber ?? -1;
            Console.WriteLine($"Final number: {finalNumber}");
        }

        private static void ShowInfo()
        {
            string helloWorld = "Hello, World!";
            string name = "Pham Van My";
            int age = 24;
            double gpa = 3.56;
            string study = "Artificial Intelligence";
            string like = "Music";
            string dislike = "Talk about old memories";

            WriteLineExample(helloWorld);
            Console.Write
            ("Hi, my name's {0}, I'm a student at VKU, and {1} years old, my major {2}, GPA: {3}, I like {4} and dislike {5}"
             , name, age, study, gpa, like, dislike);
        }

        private static void WriteLineExample(String str)
        {
            Console.WriteLine(str);
        }
    }
}
