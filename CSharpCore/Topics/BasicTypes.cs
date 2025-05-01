using System;

namespace CSharpCore.Topics
{
    public class BasicTypes
    {
        public static void ShowInfo()
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

        public static void NullableExample()
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

        // var is the keyword for declaring variables with automatic type inference..
        // Includes examples with List, Dictionary, and Array.
        public static void VarExample()
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

        public static void DynamicExample()
        {
            dynamic something = 123;
            Console.WriteLine($"{something} (Type: {something.GetType()})");

            something = 123.4;
            Console.WriteLine($"{something} (Type: {something.GetType()})");

            something = "C Sharp";
            Console.WriteLine($"{something} (Type: {something.GetType()})");

            something = true;
            Console.WriteLine($"{something} (Type: {something.GetType()})");
        }

        public static void CharExample()
        {
            Console.WriteLine("\n/* Char Example */");
            char initial = 'P';
            Console.WriteLine("Initial: " + initial);
            char digitChar = '7';
            Console.WriteLine("Is digit? " + char.IsDigit(digitChar));
        }

        public static void StringExample()
        {
            Console.WriteLine("\n/* String Example */");

            string message = "Hello C#";
            Console.WriteLine("Original message: " + message);

            // Length of the string
            Console.WriteLine("Length of message: " + message.Length);

            // String concatenation
            Console.WriteLine("Concatenation: " + message + " World!");

            // Accessing the first character of the string
            Console.WriteLine("First character: " + message[0]);

            // Convert the string to uppercase
            Console.WriteLine("ToUpper: " + message.ToUpper());

            // Check if the string contains "C#"
            Console.WriteLine("Contains 'C#'? " + message.Contains("C#"));

            // Replace "C#" with "CSharp"
            Console.WriteLine("Replace: " + message.Replace("C#", "CSharp"));

            // Get substring starting from index 6
            Console.WriteLine("Substring from index 6: " + message.Substring(6));

            // Check for empty and null strings
            string empty = "";
            string nullString = null;
            Console.WriteLine("IsNullOrEmpty(empty): " + string.IsNullOrEmpty(empty));
            Console.WriteLine("IsNullOrEmpty(nullString): " + string.IsNullOrEmpty(nullString));
        }

        public static void DecimalExample()
        {
            Console.WriteLine("\n/* Decimal Example */");
            decimal price = 19.99m;
            decimal taxRate = 0.08m;
            decimal total = price * (1 + taxRate);
            Console.WriteLine($"Price: {price}, Tax Rate: {taxRate}, Total: {total}");
        }

        public static void ConstantsExample()
        {
            Console.WriteLine("\n/* Constants Example */");
            const double PI = 3.14159;
            Console.WriteLine("Value of PI: " + PI);
            // PI = 3.14; // This would cause a compile-time error
        }
    }
}