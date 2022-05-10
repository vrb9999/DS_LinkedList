using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Add(40);
            list.Display();
            list.SortAscending();
            list.Display();
        }
    }
}
