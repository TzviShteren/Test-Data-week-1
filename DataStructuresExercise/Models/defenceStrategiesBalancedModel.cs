using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresExercise.Models
{
    internal class defenceStrategiesBalancedModel
    {
        public int MinSeverity { get; set; }
        public int MaxSeverity { get; set; }

        public List<string> Defenses = [];
        public defenceStrategiesBalancedModel? Left { get; set; }
        public defenceStrategiesBalancedModel? Right { get; set; }
    }
}
