using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace BinaryGap
{
    internal class GapClass
    {
        public int BinaryGap(int number)
        {
            int N = 0;
            List<int> gaps = new List<int>();
            var tempMax = 0;

            Console.Write($"Provided integer number= {number}\n");

            var binaryNumber = Convert.ToString(number, 2);

            Console.Write($"Number converted into binary = {binaryNumber}\n");

            foreach (char c in binaryNumber)
            {
                if (c == '0') tempMax += 1;
                if (c == '1')
                {
                    if (tempMax != 0) gaps.Add(tempMax);
                    tempMax = 0;
                }
            }
            return gaps.Max();
        }
    }
}
