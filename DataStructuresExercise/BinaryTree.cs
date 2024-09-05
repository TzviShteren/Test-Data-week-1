using DataStructuresExercise.Models;
using DataStructuresExercise.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresExercise
{
    internal class TreeNode
    {
        internal defenceStrategiesBalancedModel Value { get; set; }
        internal TreeNode? Left { get; set; }
        internal TreeNode? Right { get; set; }
        public TreeNode(defenceStrategiesBalancedModel value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
    internal class BinaryTree
    {
        public TreeNode? _root;
        public BinaryTree() => _root = null;

        public void Insert(defenceStrategiesBalancedModel data) => _root = InsertRecursive(_root, data);

        private TreeNode InsertRecursive(TreeNode? node, defenceStrategiesBalancedModel data)
        {
            if (node == null)
            {
                node = new TreeNode(data);
                return node;
            }
            if (data.MinSeverity < node.Value.MinSeverity)
                node.Left = InsertRecursive(node.Left, data);
            else
                node.Right = InsertRecursive(node.Right, data);
            return node;
        }
    }
}
