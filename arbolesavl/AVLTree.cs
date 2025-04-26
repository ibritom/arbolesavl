using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolesavl
{
    public class AVLTree
    {
        internal AVLNode? root;
        internal int height(AVLNode node)
        {
            if (node == null)
                return 0;
            return node.Height;

        }
        internal int getBalace(AVLNode node)
        {
            if (node == null)
                return 0;
            return height(node.Right) - height(node.Left);
        }
        private AVLNode rightRotate(AVLNode y)
        {
            AVLNode x = y.Left;
            AVLNode T2 = x.Right;
            // Perform rotation
            x.Right = y;
            y.Left = T2;
            // Update heights
            y.Height = Math.Max(height(y.Left), height(y.Right)) + 1;
            x.Height = Math.Max(height(x.Left), height(x.Right)) + 1;
            // Return new root
            return x;
        }
        private AVLNode leftRotate(AVLNode x)
        {
            AVLNode y = x.Right;
            AVLNode T2 = y.Left;
            // Perform rotation
            y.Left = x;
            x.Right = T2;
            // Update heights
            x.Height = Math.Max(height(x.Left), height(x.Right)) + 1;
            y.Height = Math.Max(height(y.Left), height(y.Right)) + 1;
            // Return new root
            return y;
        }
        public void insert(int value)
        {
            root = insertRecursive(root, value);
        }
        private AVLNode insertRecursive(AVLNode node, int value)
        {
            // Perform the normal BST insertion
            if (node == null)
                return new AVLNode(value);
            if (value < node.Value)
                node.Left = insertRecursive(node.Left, value);
            else if (value > node.Value)
                node.Right = insertRecursive(node.Right, value);
            else
                return node; // Duplicate values are not allowed
            // Update height of this ancestor node
            node.Height = 1 + Math.Max(height(node.Left), height(node.Right));
            // Get the balance factor
            int balance = getBalace(node);
            // If the node becomes unbalanced, then there are 4 cases
            // Left Left Case
            if (balance > 1 && value < node.Left.Value)
                return rightRotate(node);
            // Right Right Case
            if (balance < -1 && value > node.Right.Value)
                return leftRotate(node);
            // Left Right Case
            if (balance > 1 && value > node.Left.Value)
            {
                node.Left = leftRotate(node.Left);
                return rightRotate(node);
            }
            // Right Left Case
            if (balance < -1 && value < node.Right.Value)
            {
                node.Right = rightRotate(node.Right);
                return leftRotate(node);
            }
            // Return the (unchanged) node pointer
            return node;
        }


    }
}
