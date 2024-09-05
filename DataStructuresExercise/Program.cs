using DataStructuresExercise;
using DataStructuresExercise.Models;
using DataStructuresExercise.Utils;
using System.Text.Json;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Creating the binary tree by importing a JSON file with a hardware range and entering the tree:");
            DefenceStrategiesBST? binaryTree = JsonToDefenceStrategiesBST(@"C:\Users\Stern\Desktop\Data codekod2\C#\DataStructuresExercise\DataStructuresExercise\Json\defenceStrategiesBalanced.json");
            if (binaryTree == null) throw new InvalidOperationException("Error reading file");

            Thread.Sleep(4000);

            Console.WriteLine("2: Print the tree in the form of a PreOrder Traversal tree:");

            Thread.Sleep(1000);

            binaryTree.PreOrderTraversal();

            Thread.Sleep(4000);

            Console.WriteLine("3: Import threats from a JSON file:");
            List<ThreatsModel>? threats = JsonToListThreatsModel(@"C:\Users\Stern\Desktop\Data codekod2\C#\DataStructuresExercise\DataStructuresExercise\Json\threats.json");
            if (threats == null) throw new InvalidOperationException("Error reading file");

            Thread.Sleep(4000);

            Console.WriteLine("4: Implementation of attack severity calculation:");
            // built in Utils/Calculations

            Thread.Sleep(4000);

            Console.WriteLine("5: Implementing a protection search method and activating the protections one after the other:");
            foreach (var threat in threats)
            {
                int severity = (threat.Volume * threat.Sophistication) + Calculations.GetTargetValue(threat.Target);
            }
        }
        public static DefenceStrategiesBST? JsonToDefenceStrategiesBST(string str)
        {
            try
            {
                string textdefenceStrategiesBalanced = File.ReadAllText(str);
                List<defenceStrategiesBalancedModel>? dictionaryJson = JsonSerializer.Deserialize<List<defenceStrategiesBalancedModel>>(textdefenceStrategiesBalanced);
                if (dictionaryJson == null) throw new InvalidOperationException("Error reading file");
                DefenceStrategiesBST binaryTree = new DefenceStrategiesBST();
                foreach (var item in dictionaryJson)
                {
                    binaryTree.Insert(item);
                }
                return binaryTree;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static List<ThreatsModel>? JsonToListThreatsModel(string str)
        {
            try
            {
                string textThreats = File.ReadAllText(str);
                List<ThreatsModel>? dictionaryJson = JsonSerializer.Deserialize<List<ThreatsModel>>(textThreats);
                if (dictionaryJson == null) throw new InvalidOperationException("Error reading file");
                return dictionaryJson;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        
    }
}