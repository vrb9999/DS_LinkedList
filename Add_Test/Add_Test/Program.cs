using System;

namespace Add_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Find(30);
            list.AddAfter(2, 40);
            list.Display();
        }
    }
}
