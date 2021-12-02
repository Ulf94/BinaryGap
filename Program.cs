using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new GapClass();

            while (true)
            {
                Console.WriteLine("Provide number:");
                string number = Console.ReadLine();
                Console.WriteLine(x.BinaryGap(Convert.ToInt32(number)));           
                Console.ReadLine();
            }
            

        }
    }
}
