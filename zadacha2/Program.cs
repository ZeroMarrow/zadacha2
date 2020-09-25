using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                double I, W, C, U, L;
                C = Math.Pow(10, -6);
                U = 100;
                L = 0.04;
                I = U * Math.Sqrt(C / L);
                Console.WriteLine($"Амплитуда силы тока= {I}А");
                W = (L * I * I) / 2;
                Console.WriteLine($"Полная энергия= {W}Дж");



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
            

        }
    }
}

