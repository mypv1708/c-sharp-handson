using System;

namespace CSharpCore.Topics
{
    public class Operators
    {
        public static void MathematicsOperatorsExample()
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

        public static void ComparisonOperatorsExample()
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

        public static void LogicalOperatorsExample()
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

        public static void BitwiseLogicalOperatorsExample()
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

        public static void ShortAssignmentOperatorsExample()
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
    }
} 