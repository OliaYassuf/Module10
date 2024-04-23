using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{

    internal class Program
    {
        public static T Max<T>(T a, T b, T c)
        {
            T max = a;
            if (GreaterThan(b, max))
                max = b;
            if (GreaterThan(c, max))
                max = c;
            return max;
        }

        public static bool GreaterThan<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x > y;
        }
        public static T Min<T>(T a, T b, T c)
        {
            dynamic min = a;
            if (b < min)
                min = b;
            if (c < min)
                min = c;
            return min;
        }
        public static T Sum<T>(T[] array)
        {
            dynamic sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("||||||||||||||||||||1||||||||||||||||||");
            int maxInt = Max(5, 10, 7);
            double maxDouble = Max(3.5, 9.8, 6.2);

            Console.WriteLine("Maximum integer: " + maxInt);
            Console.WriteLine("Maximum floating point number: " + maxDouble);

            Console.WriteLine("||||||||||||||||||||2||||||||||||||||||");

            int minInt = Min(5, 10, 7);
            double minDouble = Min(3.5, 9.8, 6.2);

            Console.WriteLine("Minimum integer: " + minInt);
            Console.WriteLine("Minimum floating point number: " + minDouble);

            Console.WriteLine("||||||||||||||||||||3||||||||||||||||||");

            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.5, 2.5, 3.5, 4.5, 5.5 };

            int sumInt = Sum(intArray);
            double sumDouble = Sum(doubleArray);

            Console.WriteLine("Sum of integers: " + sumInt);
            Console.WriteLine("Sum of floating point numbers: " + sumDouble);

            Console.WriteLine("||||||||||||||||||||4||||||||||||||||||");
            Stack<int> intStack = new Stack<int>();

            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);

            Console.WriteLine("Count: " + intStack.Count);

            Console.WriteLine("Peek: " + intStack.Peek());

            Console.WriteLine("Pop: " + intStack.Pop());
            Console.WriteLine("Pop: " + intStack.Pop());
            Console.WriteLine("Is stack empty: " + (intStack.Count == 0));
            Console.WriteLine("Pop: " + intStack.Pop());

            Console.WriteLine("Is stack empty: " + (intStack.Count == 0));

            Console.WriteLine("||||||||||||||||||||5||||||||||||||||||");

            Queue<int> intQueue = new Queue<int>();

            intQueue.Enqueue(1);
            intQueue.Enqueue(2);
            intQueue.Enqueue(3);

            Console.WriteLine("Count: " + intQueue.Count);

            Console.WriteLine("Peek: " + intQueue.Peek());

            Console.WriteLine("Dequeue: " + intQueue.Dequeue());
            Console.WriteLine("Dequeue: " + intQueue.Dequeue());

            Console.WriteLine("Is queue empty: " + (intQueue.Count == 0));

            Console.WriteLine("Dequeue: " + intQueue.Dequeue());

            Console.WriteLine("Is queue empty: " + (intQueue.Count == 0));

        }
    }
}
