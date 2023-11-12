using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq_11._11._2023.Hidanin_Modelsleri
{
    class Calculator_Class
    {
        //Metod 1 switch ile yazilib*/
        //    public void Calculation(double num1, double num2)
        //    {
        //        Console.WriteLine("Reqemi daxil edin (+, -, *, /): ");
        //        char reqem = Convert.ToChar(Console.ReadLine());
        //        double result = 0;

        //        switch (reqem)
        //        {
        //            case '+':
        //                result = num1 + num2;
        //                break;
        //            case '-':
        //                result = num1 - num2;
        //                break;
        //            case '*':
        //                result = num1 * num2;
        //                break;
        //            case '/':
        //                if (num2 != 0)
        //                {
        //                    result = num1 / num2;
        //                }
        //                else
        //                {
        //                    Console.WriteLine("riyaziyyat biliyime gore 0 ra bolmek mumkun deyil");
        //                    return;
        //                }
        //                break;
        //            default:
        //                Console.WriteLine("düzgün operator daxil et (+, -, *, /).");
        //                return;
        //        }

        //        Console.WriteLine($"netice: {result}");
        //    }
        //

        public void Calculate(int num1, int num2)
        {
            Console.WriteLine("Hesablama emeloyyati ucun operator daxil edin...");
            char sign = Convert.ToChar(Console.ReadLine());

            var result = sign switch
            {
                '+' => num1+num2,
                '-' => num1-num2,
                '*' => num1*num2,
                '/' => num1/num2, //basqa bir elaveniz varsa comment yazarsiniz  zehmet olmasa Mr.Teacher Ulvi.
            };

            Console.WriteLine(result);
        }
    }
}