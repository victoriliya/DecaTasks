using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Task
{
    public class Node
    {
        // A node to structure an item and the next Node; 
        private object item;
        private Node next;


        public Node(object o, Node n)
        {
            Item = o;
            Next = n;
        }

        public object Item{
            get { return item; }
            set { this.item = value; }
        }

        public Node Next
        {
            get { return next; }
            set { this.next = value; }
        }



    }
}
