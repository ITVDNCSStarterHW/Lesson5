using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;

            Console.WriteLine(x += y >> x++ * z);
            Console.WriteLine(z = ++x & y * 5);
            Console.WriteLine(y /= x + 5 | z);
            Console.WriteLine(z = x++ & y * 5);
            Console.WriteLine(x = y << x++ ^ z);

            Console.ReadLine();
        }
    }
}
