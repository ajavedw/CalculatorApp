using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            int num = 10 + number;
            string anotherNum = Console.ReadLine();

            string anotherNum2 = Console.ReadLine();
            int anotherNum2Int;
            int.TryParse(anotherNum2, out anotherNum2Int);
            int sum = num + Int32.Parse(anotherNum) + anotherNum2Int;



            Console.WriteLine(sum);
        }
    }
}
