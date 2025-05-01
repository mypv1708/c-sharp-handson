using System;

namespace CSharpCore.Topics
{
    public class OOPBasics
    {
        public static void StructExample()
        {
            Console.WriteLine("\n/* Struct Example */");
            Point p1;
            p1.X = 10;
            p1.Y = 20;
            Console.WriteLine($"Point 1: X = {p1.X}, Y = {p1.Y}");
        }

        public static void EnumExample()
        {
            Console.WriteLine("\n/* Enum Example */");
            Day today = Day.Wednesday;
            Console.WriteLine($"Today is: {today} (value: {(int)today})");
        }

        public static void MoreStringManipulationExample()
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

        public static void MoreMathExamples()
        {
            Console.WriteLine("\n/* More Math Class Examples */");
            Console.WriteLine($"Math.Round(3.14159, 2): {Math.Round(3.14159, 2)}");
            Console.WriteLine($"Math.Ceiling(3.2): {Math.Ceiling(3.2)}");
            Console.WriteLine($"Math.Floor(3.8): {Math.Floor(3.8)}");
            Console.WriteLine($"Math.Abs(-5): {Math.Abs(-5)}");
        }

        public static void ExplainNamespace()
        {
            Console.WriteLine("\n/* Namespace Explanation */");
            Console.WriteLine("// Namespaces help organize your code and prevent naming conflicts.");
            Console.WriteLine("// The 'using System;' statement at the top allows you to use classes from the System namespace");
            Console.WriteLine("// without having to write 'System.' before them (e.g., Console instead of System.Console).");
            Console.WriteLine("// Your code is currently in the 'CSharpCore' namespace.");
        }
    }

    public struct Point
    {
        public int X;
        public int Y;
    }

    public enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
} 