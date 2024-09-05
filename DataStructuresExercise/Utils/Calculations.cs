using DataStructuresExercise.Models;

namespace DataStructuresExercise.Utils
{
    internal static class Calculations
    {
        public static int CalculationOfSeverity(defenceStrategiesBalancedModel defence)
        {
            return defence.MaxSeverity - defence.MinSeverity;
        }

    }
}
