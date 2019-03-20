using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {

            OperationsOnTree tree = new OperationsOnTree(5);

            tree.root.Left = new TreeNode(10);
            tree.root.Right = new TreeNode(15);
            tree.root.Left.Left = new TreeNode(12);
            tree.root.Left.Right = new TreeNode(11);
            tree.root.Right.Left = new TreeNode(20);
            tree.root.Right.Right = new TreeNode(22);

            //Now we will perform Traversals
            // Inorder traversal
            tree.inorderTraversal(tree.root);

            Console.WriteLine();
            // Post order traversal
            tree.PostorderTraversal(tree.root);
            Console.WriteLine();

            //preorder traversal
            tree.PreorderTraversal(tree.root);
            Console.WriteLine();


            //level order Traversal
            tree.LevelOrderTraversal(tree.root);
            Console.ReadKey();
           
        }
    }
}
