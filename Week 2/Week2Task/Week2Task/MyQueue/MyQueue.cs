using System;

namespace Week2Task
{
    class MyQueue<T> : MyLinkList<T>
    {
   
        public void Dequeue() { // Removes the last item in a queue 
            Remove(count-1);
        }

        public void Enqueue(T item) { // Add an item to the queue
            Add(item);
        }

    }
}
