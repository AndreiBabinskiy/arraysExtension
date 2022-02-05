using System;

namespace Laba1_Task2 { 
    class Program {
        static int[,] array;
        static int demensionArrayLines;
        static int demensionArrayColumns;
        public static int[,] createArray() { 
            Console.WriteLine("Enter the dimension of the array lines: ");
            demensionArrayLines = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the dimension of the array lines columns: ");
            demensionArrayColumns = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the min value in array: ");
            int minValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the max value in array: ");
            int maxValue = int.Parse(Console.ReadLine());
            array = new int[demensionArrayLines,demensionArrayColumns];
            Random random = new Random();
            for (int i = 0; i < demensionArrayLines; i++) {
                for (int j = 0; j < demensionArrayColumns;j++) {
                    array[i, j] = random.Next(minValue, maxValue);
                }    
            }
            return array;
        }
        public static void printArray(int[,] array) { 
            Console.WriteLine(" Array ");
            Console.WriteLine(" ------------------- ");
            for (int i = 0; i < demensionArrayLines; i++) {
                for (int j = 0; j < demensionArrayColumns; j++) {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void arithmeticMeanOfEvenElements(int[,] array) {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < demensionArrayLines; i++) { 
                for (int j = 0; j < i; j++) { 
                    if (array[i,j] % 2 == 0) {
                        sum += array[i, j];
                        count++;
                        //Console.WriteLine(count);
                    }
                }
            }
            Console.WriteLine(" --------------------- ");
            Console.WriteLine(" Sum elments = " + sum);
            Console.WriteLine(" Amount of elements = " + count);
            Console.WriteLine("\n Average even elements = " + (double)sum / count);
        }
        public static void Main(string[] args) {
            createArray();
            printArray(array);
            arithmeticMeanOfEvenElements(array);

            Console.Read();
        }
    }
}
