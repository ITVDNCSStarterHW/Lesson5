using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int exp;
            double money;

            Console.WriteLine("Введите стаж сотрудника");
            exp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Зарплата сотрудника");
            money = Convert.ToDouble(Console.ReadLine());


            if (exp < 5)
            {
                money *= 1.1; 
            }
            else if (5 <= exp && exp < 10) 
            {
                money *= 1.15;
            }
            else if (10 <= exp && exp < 15)
            {
                money *= 1.25;
            }
            else if (15 <= exp && exp < 20)
            {
                money *= 1.35;
            }
            else if (20 <= exp && exp < 25)
            {
                money *= 1.4;
            }
            else if (exp >= 25)
            {
                money *= 1.5;
            }
            Console.WriteLine(money);
            Console.ReadLine();
        }
    }
}
