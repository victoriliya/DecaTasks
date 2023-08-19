using System;
using System.Collections.Generic;

namespace Week2Task
{
    public class MyLinkList<T>
    {
        /* FIELDS */
        private Node headNode; // Every List has a head node
        protected int count; // increment the size upon creation of a new item


        // Constructor set the initial value of headNode to null and count to 0
        public MyLinkList()
        {
            this.headNode = null;
            this.count = 0;
        }

        /* METHODS */


        public bool isEmpty() // Checks if a List is empty
        {
            return this.count == 0; 
        }



        public int Add(int index, T newItem) // Add an item to a particular index
        {
            //Convert.ToInt32(index);
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index: " + index); // throws an exception if index is less than 0
            }

            if (index > count)
            {
                index = count;
            }

            Node current = this.headNode; // Sets the first node to be the headNode

            if (this.isEmpty() || index == 0) // Sets the first item to the headNode
            {
                this.headNode = new Node(newItem, this.headNode); 
            }
            else
            {
                for (int i = 0; i < index - 1; i++) // Loop to the nth Node

                {
                    current = current.Next;                 }
                current.Next = new Node(newItem, current.Next); // Inserts a new item to nth Node
            }

            count++;

            return count;

        }

        public void Add(T newItem) // Adds a new item to the end Node
        {
            this.Add(count, newItem); 
           
        }

        public bool Remove(int index) // Removes an item using index
        {
            if (index < 0)
            {
                //throw new ArgumentOutOfRangeException("Index: " + index);
            }

            if (this.isEmpty())
            {
                return false;
            }

            if (index > this.count)
            {
                index = count - 1;
            }

            Node current = this.headNode; // Sets the headNode
            object result = null;

            if (index == 0)
            {
                result = current.Item;
                this.headNode = current.Next; // Sets the head node to the currentNode
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next; // Sets the current node to nth Node
                }
                current.Next = current.Next.Next; // Sets the Node in the next two node to the current node
            }

            count--; // Decrement the size of the list
            return true;

        }


        public bool Remove(T item) // Remove an item by just passing item
        {
            if (this.headNode.Item.Equals(item))
            {
                headNode = headNode.Next; // If item is the head Node sets the Next item to be the headNode
                count--;

                return true;
            }
            else
            {
                Node temp = headNode;
                Node tempPre = headNode;
                bool matched = false;
                while (!(matched = temp.Item.Equals(item)) && temp.Next != null)
                {
                    tempPre = temp;
                    temp = temp.Next; // Get the current Node where item is located
                }
                if (matched)
                {
                    tempPre.Next = temp.Next; // If matched sets the current Node to the next Node
                    count--;
                }
                else
                {
                    Console.WriteLine("Value not found!");
                    return false;
                }
            }
            return false;
        }

        public void Clear() // remove all the item in the List
        {
            this.headNode = null;
            this.count = 0;
        }

        public void PrintAll() {
            Node current = this.headNode;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(current.Item);
                current = current.Next;
            }
        }

        public T Peek() // Returns the last item in the List
        {
            Node current = this.headNode;
            for (int i = 0; i < count; i++) // Go through all the item stored in the array
            {
                if (i == (count - 1))
                {
                    return (T)current.Item;
                }
                current = current.Next;
            }
            return  (T)current.Item; // returns the last item
        }

        public bool Check(T o) {
            Node current = this.headNode;
            for (int i = 0; i < count; i++)
            {
        
                string a = o.ToString();
                string b = current.Item.ToString();
                current = current.Next;

                if (a == b)
                {
                    return true;
                }
            }
            return false;
        }
    
        public int Index(T o) // Returns the index of the item passed
        {
           
            Node current = this.headNode;
            for (int i = 0; i < count; i++)
            {
                string a = o.ToString();
                string b = current.Item.ToString();
                current = current.Next;
          
                if (a == b)
                {

                    return i;
                }
            }
            return 0;
        }

        public int Size() { // retuns the size of the list
            return count;
        }




    }
}
