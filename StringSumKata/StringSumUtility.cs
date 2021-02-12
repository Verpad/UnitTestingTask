using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSumKata
{
    public class StringSumUtility
    {
        public string Sum(string num1, string num2)
        {
            if (String.IsNullOrEmpty(num1) || String.IsNullOrEmpty(num2) ||
                String.IsNullOrWhiteSpace(num1) || String.IsNullOrWhiteSpace(num2))
            {
                throw new ArgumentException();
            }

            int sum = ConvertToInt(num1) + ConvertToInt(num2);
            Convert.ToString(sum);

            return Convert.ToString(sum);
        }

        private static int ConvertToInt(string str)
        {
            if (str.All(Char.IsDigit))
            {
                return Convert.ToInt32(str);
            }
            return 0;
        }
    }
}
