using DataStructuresExercise.Models;

namespace DataStructuresExercise.Utils
{
    internal static class Calculations
    {
        // Code reference from https://stackoverflow.com/questions/3754582/is-there-an-easy-way-to-return-a-string-repeated-x-number-of-times
        public static string Repeat(string value, int amount) =>
         string.Concat(Enumerable.Repeat(value, amount));

    }
}
