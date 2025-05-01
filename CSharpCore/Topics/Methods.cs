using System;

namespace CSharpCore.Topics
{
    public class Methods
    {
        public static void InputDataExample()
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

        public static void OutKeywordExample(out float a, out float b)
        {
            InputData(out a, out b);
        }

        private static void InputData(out float A, out float B)
        {
            Console.Write("Input A: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Input B: ");
            B = float.Parse(Console.ReadLine());
        }

        public static void RefKeywordExample(ref float a, ref float b)
        {
            Swap(ref a, ref b);
            Console.WriteLine("After Swap: " + a + " " + b);
        }

        private static void Swap(ref float a, ref float b)
        {
            float temp = a;
            a = b;
            b = temp;
        }

        public static void ParamExample()
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

        public static void TypeCastingExample()
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
    }
} 