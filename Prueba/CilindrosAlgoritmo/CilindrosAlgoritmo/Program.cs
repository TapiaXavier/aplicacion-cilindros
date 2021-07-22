using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CilindrosAlgoritmo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Asignación de entradas de pantalla a variables de calculo
            var D = 3.5;
            double Esp = 0.125;
            var Ti = 25;
            double Df = 0.0;

            double Ai = (((D * D) * 3.141592654) / 4);
            double iT = 150 - Ti;
            var Af = (2 * (0.000012) * (Ai) * (iT)) + Ai;
            var DF = Math.Sqrt((((4) * (Af)) / (3.141592654)));
            var Apr = DF - D;
            var D2 = (D) + (2 * Esp);
            var Ai2 = (((D2 * D2) * 03.141592654) /4);
            var Af2 = (2 * (0.0000224) * (Ai2) * (iT) + Ai2);
            var DF2 = Math.Sqrt((((4) * (Af2)) / (3.141592654)));
            var Apr2 = DF2 - D2;
            var Apriete = Apr2 - Apr;
            var AprieteMilecimas = (Apriete) * (1000);
            var Tolerancia = AprieteMilecimas / 5.2;
            var DilCal = Apriete + (0.35 * Apriete);
            var Af3 = ((((D2 * D2) + DilCal) * 3.141592654) /4 );
            var IA = Af3 - Ai2;
            var K = (2) * (0.0000224) * (Ai2);
            var TemEnc = ((((IA / K)+1)* 3.3 ) + Ti);
            var ToLo = TemEnc / 13;

            Console.WriteLine("El Apriete es de: ", AprieteMilecimas + "Milecimas de Pulgada + -" + Tolerancia + "mm de pulgadas" + "--" + "es necesario calentar el monoblock hasta los" + TemEnc + "grados centigrados + -" + ToLo + "ºC");



        }
    }
}
