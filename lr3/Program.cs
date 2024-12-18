using System;

namespace lr3
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose task: 1 - One-dimensional array, 2 - Two-dimensional array");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the size of the array:");
                int n = int.Parse(Console.ReadLine());
                double[] array = new double[n];

                FillRandomArray(array, -28.35, 12.91);
                Console.WriteLine("Array: " + string.Join(", ", array.Select(x => x.ToString("F2"))));

                int product = FindNegativeIndexesProduct(array);
                Console.WriteLine($"Product of indexes of negative elements: {product}");

                Console.WriteLine("Enter k (number of elements to sort):");
                int k = int.Parse(Console.ReadLine());
                SortFirstKElementsDescending(array, k);
                Console.WriteLine("Sorted array: " + string.Join(", ", array.Select(x => x.ToString("F2"))));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the number of rows:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of columns:");
                int m = int.Parse(Console.ReadLine());

                double[,] matrix = new double[n, m];
                FillRandomMatrix(matrix, -24.9, 60.3);
                Console.WriteLine("Matrix:");
                PrintMatrix(matrix);

                int nonNegativeRows = CountNonNegativeRows(matrix);
                Console.WriteLine($"Number of rows with no negative elements: {nonNegativeRows}");

                SortRowsByDescendingSums(matrix);
                Console.WriteLine("Matrix sorted by descending row sums:");
                PrintMatrix(matrix);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static void FillRandomArray(double[] array, double min, double max)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(random.NextDouble() * (max - min) + min, 2);
            }
        }

        static int FindNegativeIndexesProduct(double[] array)
        {
            int product = 1;
            bool hasNegative = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    product *= i;
                    hasNegative = true;
                }
            }
            return hasNegative ? product : 0;
        }

        static void SortFirstKElementsDescending(double[] array, int k)
        {
            double[] sortedPart = array.Take(k).OrderByDescending(x => x).ToArray();
            for (int i = 0; i < k; i++)
            {
                array[i] = sortedPart[i];
            }
        }

        static void FillRandomMatrix(double[,] matrix, double min, double max)
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Math.Round(random.NextDouble() * (max - min) + min, 1);
                }
            }
        }

        static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString("F1") + "\t");
                }
                Console.WriteLine();
            }
        }

        static int CountNonNegativeRows(double[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool allNonNegative = true;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        allNonNegative = false;
                        break;
                    }
                }
                if (allNonNegative)
                {
                    count++;
                }
            }
            return count;
        }

        static void SortRowsByDescendingSums(double[,] matrix)
        {
            double[] rowSums = new double[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                rowSums[i] = matrix.GetLength(1) > 0 ? matrix.Cast<double>().Skip(i * matrix.GetLength(1)).Take(matrix.GetLength(1)).Sum() : 0;
            }

            var sortedIndexes = rowSums
                .Select((sum, index) => new { sum, index })
                .OrderByDescending(item => item.sum)
                .Select(item => item.index)
                .ToArray();

            double[,] sortedMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < sortedIndexes.Length; i++)
            {
                int rowIndex = sortedIndexes[i];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sortedMatrix[i, j] = matrix[rowIndex, j];
                }
            }

            Array.Copy(sortedMatrix, matrix, sortedMatrix.Length);
        }
    }

}
