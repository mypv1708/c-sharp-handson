using System;

namespace CSharpCore.Topics
{
    public class ControlFlow
    {
        public static void IfElseConditionExample()
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

        public static void SwitchCaseConditionExample()
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

        public static void WhileLoopExample()
        {
            double number;
            Console.Write("Input a number (1-100): ");
            number = double.Parse(Console.ReadLine());
            while (number < 1 || number > 100)
            {
                Console.Write("Re-Input: ");
                number = double.Parse(Console.ReadLine());
            }
            Console.Write("Valid number: " + number);
        }

        public static void DoWhileLoopExample()
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

        public static void ForLoopExample()
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

        public static void BreakConditionExample()
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

        public static void ContinueConditionExample()
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
    }
} 