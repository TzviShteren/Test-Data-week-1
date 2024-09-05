using DataStructuresExercise.Models;
using DataStructuresExercise.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructuresExercise
{
    internal class TreeNode
    {
        internal defenceStrategiesBalancedModel Value { get; set; }
        internal TreeNode? Left { get; set; }
        internal TreeNode? Right { get; set; }
        internal int Height { get; set; }
        public TreeNode(defenceStrategiesBalancedModel value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
    internal class DefenceStrategiesBST
    {
        public TreeNode? _root;
        public DefenceStrategiesBST() => _root = null;

        // O(!n)
        public void Insert(defenceStrategiesBalancedModel data) => _root = InsertRecursive(_root, data, 0);
        private TreeNode InsertRecursive(TreeNode? node, defenceStrategiesBalancedModel data, int Height)
        {
            // if the first
            if (node == null)
            {
                node = new TreeNode(data);
                node.Height = Height;
                return node;
            }
            if (data.MinSeverity < node.Value.MinSeverity)
            {
                node.Left = InsertRecursive(node.Left, data, Height + 1);
            }
            else
            {
                node.Right = InsertRecursive(node.Right, data, Height + 1);
            }
            return node;
        }

        // O(!n)
        public void PreOrderTraversal()
        {
            if (_root == null) { return ; }
            Console.WriteLine("Tree structure with left/right child distinctions:");
            PreOrderRecursive(_root, "Root"); // For starters get Root
        }
        private void PreOrderRecursive(TreeNode? node, string direction)
        {
            // if root return an empty string and if not return this sign |--
            string ifRootDoNotPrint = direction == "Root" ? "" : "|--"; 
            if (node != null)
            {
                string spacing = Calculations.Repeat(" ", node.Height); // Getting how far it should be
                Console.WriteLine($"{spacing}{ifRootDoNotPrint}{direction}: [{node!.Value.MinSeverity}-{node.Value.MaxSeverity}] " +
                    $"Defenses: {string.Join(", ", node.Value.Defenses!)}");
                PreOrderRecursive(node.Left, "Left");
                PreOrderRecursive(node.Right, "Right");
            }
        }

        // search by Severity in O(log(n))
        public TreeNode? Find(int value) => FindRecursive(_root, value);
        private TreeNode? FindRecursive(TreeNode? node, int value)
        {
            if (node == null)
                return null;
            if (node.Value.MinSeverity <= value && node.Value.MaxSeverity + 1 > value)
                return node;
            if (value < node.Value.MinSeverity)
                return FindRecursive(node.Left, value);
            else
                return FindRecursive(node.Right, value);
        }

        // Returns the minimum value
        public int Min()
        {
            if (_root == null)
                throw new InvalidOperationException("The Tree is empty");

            TreeNode? node = _root;
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node.Value.MinSeverity;
        }


        // O(!n)
        public void InOrderTraversal()
        {
            if (_root == null) { return; }
            Console.WriteLine("Tree structure with left/right child distinctions:");
            InOrderRecursive(_root, "Root"); // For starters get Root
        }
        private void InOrderRecursive(TreeNode? node, string direction)
        {
            // if root return an empty string and if not return this sign |--
            string ifRootDoNotPrint = direction == "Root" ? "" : "|--";
            if (node != null)
            {
                string spacing = Calculations.Repeat(" ", node.Height * 3); // Getting how far it should be, Double 3 to be more beauti.
                InOrderRecursive(node.Left, "Left");
                Console.WriteLine($"{spacing}{ifRootDoNotPrint}{direction}: [{node!.Value.MinSeverity}-{node.Value.MaxSeverity}] " +
                    $"Defenses: {string.Join(", ", node.Value.Defenses!)}");
                InOrderRecursive(node.Right, "Right");
            }
        }


    }
}
