using System;

namespace Laba1_Task3
{
    class Program
    {
        static int[][] array;
        static int n;
        static int maxValue;
        static void Main(string[] args)
        {
            createArray();
            printArray(array);
            minElement(array);
            Console.Read();
        }

        public static int[][] createArray()
        {
            Console.WriteLine("Enter the dimension (n) of the array: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the min value in array: ");
            int minValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the max value in array: ");
            maxValue = int.Parse(Console.ReadLine());
            array = new int[n][];
            Random random = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < n; i++)
            {
                int length;
                int[] row = array[i] = new int[length = random.Next(1, n + 1)];

                for (int j = 0; j < length; j++)
                {
                    row[j] = random.Next(minValue, maxValue);
                }
            }
            return array;
        }

        public static void printArray(int[][] array)
        {
            Console.WriteLine(" Array ");
            Console.WriteLine(" ------------------- ");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void minElement(int[][] array)
        {
            int[] columns = new int[n];

            for (int colNum = 0; colNum < n; colNum++)
            {
                int minOfColumn = maxValue + 1;
                for (int rowNum = 0; rowNum < n; rowNum++)
                {
                    if (array[rowNum].Length <= colNum)
                    {
                        continue;
                    }
                    if (array[rowNum][colNum] < minOfColumn)
                    {
                        minOfColumn = array[rowNum][colNum];

                    }
                }
                columns[colNum] = minOfColumn;
            }
            Console.WriteLine("\n~~ Min Elements ~~");
            foreach (int value in columns)
            {
                if (value > maxValue)
                {
                    Console.Write(" N/A");
                }
                else
                {
                    Console.Write(" " + value);
                }
            }
        }
    }

}
