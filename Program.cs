using System;

namespace Assignment6._2._1
{
    internal class Program
    {
        //Write a C# program to implement a stack by using array with push and pop operations
        static void Main(string[] args)
        {
            //initialize the stack
            int size = 5;
            int[] stack = new int[size];
            int top = -1;

            //push elements onto the stack
            Console.WriteLine("Pushing elements onto the stack...");
            for (int i = 1; i <= 3; i++)
            {
                if (top == size - 1)
                {
                    Console.WriteLine("Stack Overflow! Unable to push.");
                    break;
                }
                top++;
                stack[top] = i * 10;
                Console.WriteLine($"Pushed {stack[top]} onto the stack.");
            }

            //display stack contents
            Console.WriteLine("\nCurrent stack contents:");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }

            //pop elements from the stack
            Console.WriteLine("\nPopping elements from the stack...");
            while (top >= 0)
            {
                Console.WriteLine($"Popped {stack[top]} from the stack.");
                top--;
            }

            if (top == -1)
            {
                Console.WriteLine("The stack is now empty.");
            }
        }
    }
}
