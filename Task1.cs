using System;

namespace Laba1_Task1 {
    class Program {
        static int[] array;
        public static int[] createArray() {
            Console.WriteLine("Enter the dimension of the array: ");
            int demensionArray = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the min value in array: ");
            int minValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the max value in array: ");
            int maxValue = int.Parse(Console.ReadLine());
            array = new int[demensionArray];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++) {
                array[i] = random.Next(minValue, maxValue);
            }
            return array;
        }
        public static void printArray(int[] array)  {
            Console.WriteLine(" Initial array ");
            Console.WriteLine(" -------------- ");
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }
        }

        public static void replaceAllElements(int[] array) {
            Console.WriteLine("Enter a number less then in the array: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(" Change Array ");
            Console.WriteLine(" ------------ ");
            for (int i = 0; i < array.Length; i++) { 
                if (array[i] > k) {
                    array[i] = k;
                }
                Console.WriteLine(array[i]);
            }
        }

        public static void findAllMinElemnets(int [] array) {
            
            int value = array[0];
            for (int i = 0; i < array.Length; i++) { 
                if (array[i] < value) {
                    value = array[i];
                }
                //Console.WriteLine(value);
            }

            Console.WriteLine(" The minimum value of the array = " + value);
            Console.WriteLine(" ----------------------------------------- ");
            int sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++) { 
                if (array[i] == value) {      
                    sum = i;
                    count++;
                    Console.WriteLine(" The minimum element of the array № = " + sum);
                }
            }
            Console.WriteLine(" ***************************************** ");
            Console.WriteLine(" Amount of all minimum elements = " + count);
            Console.WriteLine(" ----------------------------------------- ");
        }

        public static void Main(string[] args) {
            createArray();
            printArray(array);
            findAllMinElemnets(array);
            replaceAllElements(array);

            Console.Read();
        }
    }
}
