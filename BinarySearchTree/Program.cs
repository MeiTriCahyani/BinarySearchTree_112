using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
       public string info;
       public Node lchild;
       public Node rchild;
       //constructor for the node class
       public Node(string i, Node l, Node r)
       {
            info = i;
            lchild = l;
            rchild = r;

       }

    }
    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; //initializing ROOT to null
        }

        public void insert(string element) //insert a node in the binary
        {
            Node tmp, parent = null,currentNode=null;
            find(element, ref parent, ref currentNode);
            if(currentNode != null)//
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else //if the specified node is not present
            {
                tmp = new Node(element, null, null);
                if(parent == null)
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element,parent.info) <0)
                {
                    if (string.Compare(element, parent.info) < 0)
                        parent.lchild = tmp;
                }
            }
        }
        
        public void find (string element, ref Node parent, ref Node currentnode)
        {
            currentnode = ROOT;
            parent = null;
            while ((currentnode !=  null) && (currentnode.info != element))
            {
                parent = currentnode;
                if (string.Compare(element,currentnode.info) < 0)
                    currentnode= currentnode.lchild;
                else  
                    currentnode= currentnode.rchild;
            }
        }

        public void inorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("tree is empty");
                return;
            }
            if (ptr != null)
            {
                inorder(ptr.lchild);
                Console.WriteLine(ptr.info + " ");
                inorder(ptr.rchild);
            }
        }
        public void preorder(Node ptr)
        {
            if(ROOT == null)
            {
                Console.WriteLine("tree is empty");
                return;
            }
            if (ptr != null)
            {
                Console.WriteLine(ptr.info + " ");
                preorder(ptr.lchild);
                preorder(ptr.rchild);
            }
        }
        public void postorder(Node ptr)
        {
            if(ROOT == null)
            {
                Console.WriteLine("tree is empty");
                return ;
            }
            if (ptr != null)
            {
                postorder(ptr.lchild);
                postorder(ptr.rchild);
                Console.Write(ptr.info + " ");
            }
        }
        static void Main(string[] args)
        {
             BinaryTree X= new BinaryTree();
            while (true)
            {
                Console.WriteLine(" \n Menu");
                Console.WriteLine("1.implement insert operation");
                Console.WriteLine("2. perform inorder treversal");
                Console.WriteLine("3. perform preorder treversal");
                Console.WriteLine("4. perform postorder treversal");
                Console.WriteLine("5. exit");
                Console.Write("\n enter your choice(1-5):");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case '1':
                        Console.WriteLine(" enter a word :");
                        string word = Console.ReadLine();
                        X.insert(word);
                        break;
                    case '2':
                        X.inorder(X.ROOT);
                        break;
                    case '3':
                        X.preorder(X.ROOT);
                        break;
                    case '4':
                        X.preorder(X.ROOT);
                        break;
                    case '5':
                        return;
                    default:
                        {
                            Console.WriteLine("Invalid option");
                            return;
                        }
                }
            }
        }
    }
}
