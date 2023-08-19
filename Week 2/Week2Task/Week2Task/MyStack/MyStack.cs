using System;

namespace Week2Task
{
    public class MyStack<T> : MyLinkList<T>
    {
        public void Pop()
        {
            Remove(0);
        }

        public void Push(T item)
        {
            Add(item);
        }



    }
}
