using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            BinarySearchTree Obj= new BinarySearchTree();
            Obj.Insert(56);
            Obj.Insert(30);
            Obj.Insert(70);
            Obj.Insert(22);
            Obj.Insert(40);
            Obj.Insert(11);
            Obj.Insert(16);
            Obj.Insert(3);
            Obj.Insert(60);
            Obj.Insert(95);
            Obj.Insert(65);
            Obj.Insert(63);
            Obj.Insert(67);
            Console.WriteLine("inorder traversal of binary tree :");
            Obj.InorderTravalsal(Obj.root);
            Console.WriteLine("\n");

            Console.WriteLine("enter the data to be search :");

            int search=Convert.ToInt32(Console.ReadLine());
            Node node = Obj.Search(63);
            if (node == null)
            {
                Console.WriteLine("Node not found");
            }
            else
            {
                Console.WriteLine("Node found: " + node.data);
            }
            Console.Read();
        }
    }
}