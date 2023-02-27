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
            BinarySearchTree bst= new BinarySearchTree();
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.InorderTravalsal(bst.root);
            Console.Read();
        }
    }
}