using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ListView.ExamineList();
                        break;
                    case '2':
                        QueueView.ExamineQueue();
                        break;
                    case '3':
                        StackView.ExamineStack();
                        break;
                    case '4':
                        ParenthesisCheck.CheckParanthesis();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

    }
}

/*
Page 3 Answers:

1. Stack: Used for function calls and local variables, LIFO. Fast and predictable.
   Heap: Used for dynamic memory allocation, objects with varying lifetimes. Manual allocation.

Illustration:
void StackExample() {
    int x = 5; // Variable x is stored on the stack
    int y = x; // Copies the value of x to y
}
void HeapExample() {
    int[] arr = new int[5]; // Allocates an array on the heap
    arr[0] = 5; // Assigns a value to the first element
    int[] arr2 = arr; // Copies the reference to arr2, both point to the same array on the heap
}

2. Value Types: Store actual values, copy on assignment (e.g., int, struct).
   Reference Types: Store references to data, share on assignment (e.g., class, array).

3. ReturnValue(): Returns 3 because integers are value types.
   ReturnValue2(): Returns 4 because objects of MyInt (a reference type) are shared, and the value is 
   modified through both references.

*/