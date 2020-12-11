using System;
using System.Linq;
using System.Collections.Generic;

namespace hacker_rank_tree_level_order_traversal
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input the number of nodes: ");
            int numberOfNodes = int.Parse(Console.ReadLine());
            Node root = null;
            Console.WriteLine("Input the nodes: ");
            while (numberOfNodes-- > 0)
            {
                int data = int.Parse(Console.ReadLine());
                root = Insert(root, data);
            }
            LevelOrder(root);
            Console.ReadKey();
        }

        private static Node Insert(Node root, int data)
        {
            if (root is null)
            {
                return new Node(data);
            }
            else
            {
                Node currentNode;
                if (data < root.Data)
                {
                    currentNode = Insert(root.Left, data);
                    root.SetLeftNode(currentNode);
                }
                else
                {
                    currentNode = Insert(root.Right, data);
                    root.SetRightNode(currentNode);
                }
                return root;
            }
        }

        private static void LevelOrder(Node root)
        {
            if (root is null)
            {
                return;
            }

            List<Node> nodes = new List<Node>
            {
                root
            };

            while (nodes.Count > 0)
            {
                Node currentNode = nodes.FirstOrDefault();
                nodes.Remove(currentNode);

                Console.Write($"{currentNode.Data} ");
                if (currentNode.Left is not null) nodes.Add(currentNode.Left);
                if (currentNode.Right is not null) nodes.Add(currentNode.Right);
            }

        }
    }
}
