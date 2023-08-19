using System;
using System.Collections;

namespace RemoveAllItemFromArrayList
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList al = new ArrayList() { 1, "hello", 3, 4, 5, "hello", 6, 9 };

            //Hey wassup... This is cool
            /*Wow..*/
            // Amazing 

            foreach (object o in al)
            {
                Console.WriteLine(o.GetType() + " " + o);
                if (o.GetType() != typeof(int))
                {
                    al.Remove(o);
                    break;
                }

            }

            foreach (object o in al)
            {
                Console.Write(o + " ");
            }
        }
    }
}
