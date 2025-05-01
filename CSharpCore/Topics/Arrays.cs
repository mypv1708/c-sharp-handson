using System;

namespace CSharpCore.Topics
{
    public class Arrays
    {
        public static void Array1DimensionExample()
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

        public static void Array2DimensionExample()
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

        public static void JaggedArrayExample()
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

        public static void ArrayClassExample()
        {
            Array arr = Array.CreateInstance(typeof(int), 5);
            for (int i = 0; i < arr.Length; i++)
                arr.SetValue(i * 10, i);
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine($"arr[{i}] = {arr.GetValue(i)}");
        }
    }
} 