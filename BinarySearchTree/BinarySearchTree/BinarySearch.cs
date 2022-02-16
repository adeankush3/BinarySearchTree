using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearch
    {
        public Node root_node;
        
        public BinarySearch()
        {
            root_node = null;
        }
       
        public void InsertNode(int element)
        {
            if (root_node == null)
            {
                root_node = new Node(element);
                return;
            }
            InsertElement(root_node, new Node(element));
        }

       
        public void InsertElement(Node root, Node newNode)
        {
            if (root == null)
            {
                root = newNode;
            }

            if (newNode.Element < root.Element)
            {
                if (root.Left == null)
                {
                    root.Left = newNode;
                }
                else
                {
                    InsertElement(root.Left, newNode);
                }
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = newNode;
                }
                else
                {
                    InsertElement(root.Right, newNode);
                }
            }
        }

       
        public void Display(Node root)
        {
            if (root == null)
            {
                return;
            }

            Display(root.Left);
            Console.Write(root.Element + ", ");
            Display(root.Right);
        }

       
        public void Display()
        {
            Console.WriteLine("Elements Of Tree");
            Display(root_node);
        }
        public void Search(int element)
        {
            if (root_node == null)
            {
                Console.WriteLine("Array is Empty.");
            }

            if (root_node.Equals(element))
            {
                Console.WriteLine("Match found");
            }

            if (root_node.Equals(element))
            {

                if (root_node.Right.Equals(element))
                {
                    Console.WriteLine("Match");
                }
            }

            if (root_node.Equals(element))
            {
                if (root_node.Left.Equals(element))
                {
                    Console.WriteLine("Match");
                }
            }
        }

    }
}
