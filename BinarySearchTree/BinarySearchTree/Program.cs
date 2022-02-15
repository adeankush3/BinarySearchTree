using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Bianary search Tree Program");

            BinarySearch tree = new BinarySearch();

            tree.InsertNode(56);
            tree.InsertNode(30);
            tree.InsertNode(70);

            tree.InsertNode(22);
            tree.InsertNode(40);
            tree.InsertNode(95);
            tree.InsertNode(60);
            tree.InsertNode(11);
            tree.InsertNode(3);
            tree.InsertNode(65);
            tree.InsertNode(16);
            tree.InsertNode(67);
            tree.InsertNode(63);

            tree.Display();
        }
    }
}
