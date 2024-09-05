using DataStructuresExercise.Models;
using System;
using System.Text.Json;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Stern\Desktop\Data codekod2\C#\DataStructuresExercise\DataStructuresExercise\Json\defenceStrategiesBalanced.json");
            var dictionaryJson = JsonSerializer.Deserialize<List<defenceStrategiesBalancedModel>> (text);
            


        }
    }
}