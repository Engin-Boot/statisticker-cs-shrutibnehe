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
                float max = numbers.Max();
                float min = numbers.Min();
                float average = numbers.Average();

                statistics.max = max;
                statistics.min = min;
                statistics.average = average;
                return statistics;
            }
        }
    }
}
