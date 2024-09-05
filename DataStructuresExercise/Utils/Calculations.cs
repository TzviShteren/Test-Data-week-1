namespace DataStructuresExercise.Utils
{
    internal static class Calculations
    {
        // Code reference from https://stackoverflow.com/questions/3754582/is-there-an-easy-way-to-return-a-string-repeated-x-number-of-times
        // to repeat a something amount of times --> O(n).
        public static string Repeat(string value, int amount) =>
         string.Concat(Enumerable.Repeat(value, amount));

        // Get Target Value by mapping --> O(1).
        public static int GetTargetValue(string value) =>
            value switch
            {
                "Web Server" => 10,
                "Database" => 15,
                "User Credentials" => 20,
                _ => 5,
            };
    }
}
