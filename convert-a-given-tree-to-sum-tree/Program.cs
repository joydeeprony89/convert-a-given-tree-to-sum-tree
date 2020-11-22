using System;

namespace convert_a_given_tree_to_sum_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(10);
            root.left = new Node(-2);
            root.right = new Node(6);
            root.right.left = new Node(7);
            root.right.right = new Node(5);
            root.left.left = new Node(8);
            root.left.right = new Node(-4);
            ToSumTree(root);
            PreOrder(root);
        }

        public class Node
        {
            public int val { get; set; }
            public Node left { get; set; }
            public Node right { get; set; }
            public Node(int val = 0)
            {
                this.val = val;
                left = right = null;
            }
        }

        static int ToSumTree(Node root)
        {
            if (root == null) return 0;
            int old_val = root.val;
            root.val = ToSumTree(root.left) + ToSumTree(root.right);
            return old_val + root.val;
        }

        static void PreOrder(Node root)
        {
            if (root == null) return;
            Console.WriteLine(root.val);
            PreOrder(root.left);
            PreOrder(root.right);
        }
    }
}
