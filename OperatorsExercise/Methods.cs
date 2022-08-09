using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExercise
{
    public class Methods
    {
        public static void QuotientRemain()
        {
            Console.WriteLine("Give me a number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number:");
            int b = int.Parse(Console.ReadLine());

            int quotient = a / b;
            int remainder = a % b;

            if (a == a && b == b)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }
        }
    }
}
