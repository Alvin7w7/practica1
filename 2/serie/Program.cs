using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie
{
    public static class Serie
    {
        public static void GenerarS(int n)
        {
            int fac = 1;
            string serie1 = "Serie: 1";
            string serie2 = "Serie2: ";

            for (int i = 2; i <= n; i++)
            {
                fac *= i;
                serie1 += "," + fac.ToString();

                if (i <= n)
                {
                    int potencia = (int)Math.Pow(2, i - 1);
                    serie2 += potencia.ToString() + ",";
                }
            }

            Console.WriteLine(serie1);
            Console.WriteLine(serie2.Substring(0, serie2.Length - 1));
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());
            Serie.GenerarS(num);
            Console.ReadKey();
        }
    }
}
