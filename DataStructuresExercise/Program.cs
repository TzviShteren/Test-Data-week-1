using DataStructuresExercise.Models;
using System.Text.Json;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {

                string text = File.ReadAllText(@"C:\Users\Stern\Desktop\Data codekod2\C#\DataStructuresExercise\DataStructuresExercise\Json\defenceStrategiesBalanced.json");
                List<defenceStrategiesBalancedModel>? dictionaryJson = JsonSerializer.Deserialize<List<defenceStrategiesBalancedModel>>(text);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}