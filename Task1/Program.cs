using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte operand1;
            byte checkValue = 1;
            byte result;

            Console.WriteLine("Число для проверки");
            operand1 = Convert.ToByte(Console.ReadLine());

            result =(byte)(operand1 & checkValue);

            if (result == 0)
            {
                Console.WriteLine("Число {0} четное", operand1);
            }
            else
            {
                Console.WriteLine("Число {0} нечетное", operand1);
            }
            Console.ReadLine();
        }
    }
}
