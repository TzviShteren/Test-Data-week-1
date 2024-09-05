﻿using DataStructuresExercise.Models;
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
        internal int Depth { get; set; }
        internal int Height { get; set; }
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

        public void Insert(defenceStrategiesBalancedModel data) => _root = InsertRecursive(_root, data, 0);

        private TreeNode InsertRecursive(TreeNode? node, defenceStrategiesBalancedModel data, int Height)
        {
            if (node == null)
            {
                node = new TreeNode(data);
                node.Depth = 0;
                node.Height = Height;
                return node;
            }
            if (data.MinSeverity < node.Value.MinSeverity)
            {
                node.Depth++;
                node.Left = InsertRecursive(node.Left, data, Height + 1);
            }
            else
            {
                node.Depth++;
                node.Right = InsertRecursive(node.Right, data, Height + 1);
            }
            return node;
        }

        public void PreOrderTraversal()
        {
            if (_root == null) { return ; }
            Console.WriteLine("Tree structure with left/right child distinctions:");
            PreOrderRecursive(_root, "Root");
        }
        private void PreOrderRecursive(TreeNode? node, string direction)
        {
            string ifRootDoNotPrint = direction == "Root" ? "" : "|--";
            if (node != null)
            {
                string spacing = Calculations.Repeat(" ", node.Height);
                Console.WriteLine($"{spacing}{ifRootDoNotPrint}{direction}: [{node!.Value.MinSeverity}-{node.Value.MaxSeverity}] " +
                    $"Defenses: {string.Join(", ", node.Value.Defenses)}");
                PreOrderRecursive(node.Left, "Left");
                PreOrderRecursive(node.Right, "Right");
            }
        }
    }
}
