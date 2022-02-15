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

            tree.Display();
        }
    }
}
