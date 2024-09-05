using DataStructuresExercise.Models;
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


    }
}
