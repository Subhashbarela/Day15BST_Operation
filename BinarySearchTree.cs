using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinarySearchTree
{
    internal class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
           this. root = null;  
        }
        public void Insert(int data)
        {
            Node newNode = new Node(data);
            if(root ==null)
            {
                root = newNode;
            }
            else
            {
                Node current= root;
                Node parent;
                while(true)
                {
                    parent= current;
                    if(data<current.data)
                    {
                        current = current.left;
                        if(current==null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if(current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        public void InorderTravalsal(Node node)
        {
            if(node !=null)
            {
                InorderTravalsal(node.left);
                Console.WriteLine(node.data+" ");
                InorderTravalsal(node.right);


            }
        }
    }
}
