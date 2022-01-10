using System;
using System.Linq;

namespace AssignmentArraysNew
{
    class Program
    {
        static void Main(string[] args)
        {
            For_ExerciseWithArray();
        }

        static void For_ExerciseWithArray()
        {
            int n = ReadNumber("How many elements has the vector? ");
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ReadNumber($"Element at index {i}=");
            }

            // print minimum element             
            FindMinArray1(array);
            //FindMinArray2(array);      

            // print maximum element 
            FindMaxArray1(array);
            //FindMaxArray2(array);

            //the index of an element
            FindIndexElement(array);

            // print Average of elements  
            ArithmeticMeanElement(array);
        }

        // print minimum element  
        public static void FindMinArray1(int[] array)
        {
            int minIndex = -1;
            int minInt = Int32.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                if (value < minInt)
                {
                    minInt = value;
                    minIndex = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Minimum element = {minInt}, on index {minIndex}.");
        }
        public static void FindMinArray2(int[] array)
        {
            Console.WriteLine();
            int minValue = array.Min();
            int minIndex = array.ToList().IndexOf(minValue);
            Console.WriteLine($"Minimum element = {minValue}, on index {minIndex}.");
        }

        // print maximum element 
        public static void FindMaxArray1(int[] array)
        {
            int maxIndex = -1;
            int maxInt = Int32.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                if (value > maxInt)
                {
                    maxInt = value;
                    maxIndex = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Maximum element = {maxInt}, on index {maxIndex}.");
        }
        public static void FindMaxArray2(int[] array)
        {
            Console.WriteLine();
            int maxValue = array.Max();
            int maxIndex = array.ToList().IndexOf(maxValue);
            Console.WriteLine($"Maximum element = {maxValue}, on index {maxIndex}.");
        }

        //the index of an element
        public static void FindIndexElement(int[] myArray)
        {
            Console.WriteLine();
            int element = ReadNumber("Element = ");

            int index = Array.IndexOf(myArray, element);
            if (index != -1)
            {
                Console.WriteLine($"Element = {element} is found at index {index}.");
            }
            else
            {
                Console.WriteLine("Element not found in the given array.");
            }
        }

        // print Average of elements  
        public static void ArithmeticMeanElement(int[] myArray)
        {
            Console.WriteLine();
            Console.Write("The Average of elements is: ");

            double average = 0;
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }
            average = sum / myArray.Length;

            Console.Write(average);

        }

        static int ReadNumber(string label)
        {
            Console.Write(label);
            string value = Console.ReadLine();
            int valueAsNumber = Convert.ToInt32(value);
            return valueAsNumber;
        }
    }

}
