using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMVWhile
{
    class Program
    {
        static double fact(double k)
        {
            if (k < 2) return 1;
            else return k * fact(k - 1);
        }
        static void Main(string[] args)
        {
            double tochnosti;
            double x;
            Console.WriteLine("Введите  данные:");
        ggo:       try
            {
                string vvod = Console.ReadLine();
                string[] info = vvod.Split(' ');
                x = Convert.ToDouble(info[0].Replace('.', ','));
                tochnosti = Convert.ToDouble(info[1].Replace('.', ','));
            }
            catch
            {
                Console.WriteLine("Введены некорректные данные! Пожалуйста повторите ввод:");
                goto ggo;
            }
            double k = 0;
            double summ2 = 0; 

            while (Math.Abs(Math.Pow(x, k)/fact(k)) >= tochnosti)
            { 
                summ2 += Math.Cos(k * Math.PI / 4) / fact(k) * Math.Pow(x, k);
                k++;
            }
            Console.WriteLine("Итоговое значение:");
            Console.WriteLine(summ2);
            Console.ReadLine();
        }
    }
}
