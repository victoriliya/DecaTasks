using System;
using System.Collections;
using System.Collections.Generic;

namespace LearnQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue();

            myQueue.Enqueue(1);
            myQueue.Enqueue("Deque");
            myQueue.Enqueue("Enq");
            myQueue.Enqueue(45);

            Console.WriteLine("1 in Queue : {0}", myQueue.Contains(1));

            // Console.WriteLine("Remove : {0}", myQueue.Dequeue());


            Console.WriteLine("Peek : {0}", myQueue.Peek());

            object[] myObjectArray = (object[])myQueue.ToArray();

            string strRep = string.Join(", ", myObjectArray);


            Console.WriteLine(strRep);

        }
    }
}
