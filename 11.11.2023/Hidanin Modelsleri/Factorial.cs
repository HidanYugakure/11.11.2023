using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq_11._11._2023.Hidanin_Modelsleri;
class Factorial
{
    public void FactorialHesablanmasi(int num)
    {
        if (num < 0)
        {
            Console.WriteLine("Riyazi biliklerime esasen Factorial hesab edilmir");
        }
        else if (num == 0)
        {
            Console.WriteLine("1-e beraberdir");
        }
        else if (num >= 1)
        {
            int count = 1;
            for (int i = 1; i <= num; i++)
            {
                count *= i;
            }
            Console.WriteLine($"{num} ededinin factoriali {count} dur");
        }
    }
}