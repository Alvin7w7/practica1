using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumLit
{
    public static class NumeroEnLetras
    {
        private static readonly string[] U = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
        private static readonly string[] D = { "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" };
        private static readonly string[] D2 = { "", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
        private static readonly string[] C = { "", "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };

        public static string ConvLetra(int num)
        {
            if (num == 0) return U[0];
            if (num < 0) return "menos " + ConvLetra(Math.Abs(num));

            string palabras = "";

            if ((num / 1000000) > 0)
            {
                palabras += ConvLetra(num / 1000000) + " millones ";
                num %= 1000000;
            }

            if ((num / 1000) > 0)
            {
                palabras += ConvLetra(num / 1000) + " mil ";
                num %= 1000;
            }

            if ((num / 100) > 0)
            {
                palabras += C[num / 100] + " ";
                num %= 100;
            }

            if (num > 0)
            {
                if (num < 10)
                    palabras += U[num];
                else if (num < 20)
                    palabras += D[num - 10];
                else
                {
                    palabras += D2[num / 10];
                    if ((num % 10) > 0)
                        palabras += " y " + U[num % 10];
                }
            }

            return palabras;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese un número:  ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Literal:  " + NumeroEnLetras.ConvLetra(num));
            Console.ReadKey();
        }
    }

}
