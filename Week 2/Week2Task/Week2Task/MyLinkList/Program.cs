using System;

namespace Week2Task
{
    class Program
    {
        static void Main(string[] args)
        {

            MyLinkList<string> list = new MyLinkList<string>();
          

            MyQueue<int> queue = new MyQueue<int>();

            MyStack<string> stack = new MyStack<string>();

            stack.Push("This");
            stack.Push("Is");
            stack.Push("it");

            stack.Pop();

            stack.PrintAll();

            //Console.WriteLine(stack.Peek());
        }
    }
}
