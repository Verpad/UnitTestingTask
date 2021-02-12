using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzzUtility
    {
        public string[] GenerateElements()
        {
            string[] elements = new string[100];

            for (int i = 0; i < elements.Length; i++)
            {
                if ((i + 1) % 15 == 0)
                {
                    elements[i] = "FizzBuzz";
                }
                else if ((i + 1) % 5 == 0)
                {
                    elements[i] = "Buzz";
                }
                else if ((i + 1) % 3 == 0)
                {
                    elements[i] = "Fizz";
                }
                else
                {
                    elements[i] = (i + 1).ToString();
                }
            }
            return elements;
        }
    }
}
