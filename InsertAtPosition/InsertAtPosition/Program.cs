using System;

namespace InsertAtPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.AddAfter(0, 30);
            list.Display();
        }
    }
}
