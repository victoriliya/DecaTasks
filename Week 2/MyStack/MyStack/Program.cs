using System;
using System.Collections;
using System.Collections.Generic;

namespace MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue("This ");
            myQueue.Enqueue("Is ");
            myQueue.Enqueue("The ");
            myQueue.Enqueue("Best ");

            Console.WriteLine("Queue peek: {0}", myQueue.Peek());

            Stack stack = new Stack();
            
            stack.Push("you drive me crazy all night long");
            stack.Push("The Dream");
            stack.Push("This is the end count from this to three");

            object[] stringObjectArray = stack.ToArray();

            Console.WriteLine(string.Join(", ", stringObjectArray));

            Console.WriteLine("Peek : {0}", stack.Peek());
            
            foreach (object o in stack)
            {
                Console.WriteLine($"Stack : {o}");
            }

        }
    }
}
