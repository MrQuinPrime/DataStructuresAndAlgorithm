using System;

namespace DS06.BinarySTree
{
    class Program
    {
        static void Main()
        {
            var bt = new BinaryTree();
            bt.Insert("D", 10000);
            bt.Insert("B", 10000);
            bt.Insert("F", 10000);
            bt.Insert("A", 10000);
            bt.Insert("C", 10000);
            bt.Insert("E", 10000);
            bt.Insert("G", 10000);
        }
    }
}
