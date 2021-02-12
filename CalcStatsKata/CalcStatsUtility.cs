using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcStatsKata
{
    public class CalcStatsUtility
    {
        public int ElementsCount;
        public int MaxValue;
        public int MinValue;
        public double AverageValue;

        public void ProcessElements(int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException();
            }

            if (elements.Length == 0)
            {
                ElementsCount = 0;
                return;
            }

            ElementsCount = elements.Length;
            MaxValue = elements.Max();
            MinValue = elements.Min();
            AverageValue = elements.Average();
        }
    }
}
