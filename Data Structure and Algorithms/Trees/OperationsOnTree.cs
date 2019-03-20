using System;
using System.Collections.Generic;

namespace Trees
{
    class TreeNode
    {
        public int data { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int data)
        {
            this.data = data;
            Left = null;
            Right = null;
        }
    }


    class OperationsOnTree
    {
        public TreeNode root;

        /// <summary>
        /// operations on Tree
        /// </summary>
        /// <param name="data"></param>
        public OperationsOnTree(int data)
        {
            root = new TreeNode(data);
        }

        /// <summary>
        /// inorder Traversal (BFS)
        /// </summary>
        /// <param name="root"></param>
        public void inorderTraversal(TreeNode root)
        {
            //write termination condition
            if (root == null)
            {
                return;
            }
            else
            {
                inorderTraversal(root.Left);
                Console.Write($"{root.data} ,");
                inorderTraversal(root.Right);
            }
        }

        /// <summary>
        /// Post Traversal BFS
        /// </summary>
        /// <param name="root"></param>
        public void PostorderTraversal(TreeNode root)
        {
            //write termination condition
            if (root == null)
            {
                return;
            }
            else
            {
                PostorderTraversal(root.Left);
                PostorderTraversal(root.Right);
                Console.Write($"{root.data} ,");
               
            }
        }

        /// <summary>
        /// Pre Traversal BFS
        /// </summary>
        /// <param name="root"></param>
        public void PreorderTraversal(TreeNode root)
        {
            //write termination condition
            if (root == null)
            {
                return;
            }
            else
            {
                Console.Write($"{root.data} ,");
                PreorderTraversal(root.Left);
                PreorderTraversal(root.Right);
               
            }
        }

        /// <summary>
        /// level order traversal
        /// </summary>
        /// <param name="root"></param>
        public void LevelOrderTraversal(TreeNode root)
        {
            //create a queue

            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                TreeNode node = queue.Dequeue();

                Console.Write($"{node.data} ");

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
        }
    }
}
