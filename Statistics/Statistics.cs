using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
       public float min;
       public float max;
       public float average;
     
    }
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            Stats statistics = new Stats();
            if (numbers.Count==0)
            {
                statistics.max = float.NaN;
                statistics.min = float.NaN;
                statistics.average = float.NaN;
                return statistics;
             }
            else
            {
                statistics.max = numbers.Max();
                statistics.min = numbers.Min();
                statistics.max = numbers.Average();
                return statistics;
            }
        }
    }
}
