using System;

namespace TreeFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Tree BinarySearchTree = new Tree();
            BinarySearchTree.Insert(30);
            BinarySearchTree.Insert(35);
            BinarySearchTree.Insert(50);
            BinarySearchTree.Insert(15);
            BinarySearchTree.Insert(60);
            BinarySearchTree.Insert(40);
            BinarySearchTree.Insert(80);
            BinarySearchTree.Insert(75);
            BinarySearchTree.Insert(65);
            BinarySearchTree.Insert(90);
            BinarySearchTree.Insert(85);
            Console.WriteLine("Inorder Traversal is: ");
            BinarySearchTree.In_order(BinarySearchTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Preoder Traversal is: ");
            BinarySearchTree.Pre_order(BinarySearchTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Postoder Traversal is: ");
            BinarySearchTree.Post_order(BinarySearchTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();

        }
        class Node1
        {
            public int value;
            public Node1 left;
            public Node1 right;
            public void show()
            {
                Console.WriteLine("[");
                Console.WriteLine(value);
                Console.WriteLine("]");
            }
        }
        class Tree
        {
            public Node1 root;
            public Tree()
            {
                root = null;
            }
            public Node1 ReturnRoot()
            {
                return root;
            }
            public void Insert(int x)
            {
                Node1 newNode = new Node1();
                newNode.value = x;
                if (root == null)
                    root = newNode;
                else
                {
                    Node1 current = root;
                    Node1 parent;
                    while (true)
                    {
                        parent = current;
                        if (x < current.value)
                        {
                            current = current.left;
                            if (current == null)
                            {
                                parent.left = newNode;
                                return;
                            }
                        }
                        else
                        {
                            current = current.right;
                            if (current == null)
                            {
                                parent.right = newNode;
                                return;
                            }
                        }

                    }
                }
            }
            public void Pre_order(Node1 Root)
            {
                if (Root != null)
                {
                    Console.WriteLine(Root.value + " ");
                    Pre_order(Root.left);
                    Pre_order(Root.right);
                }
            }
            public void In_order(Node1 Root)
            {
                if (Root != null)
                {
                    In_order(Root.left);
                    Console.WriteLine(Root.value + " ");
                    In_order(Root.right);
                }
            }
            public void Post_order(Node1 Root)
            {
                if (Root != null)
                {
                    Post_order(Root.left);
                    Post_order(Root.right);
                    Console.WriteLine(Root.value + " ");
                }
            }
        }

        // END BRACKETS
    }
}