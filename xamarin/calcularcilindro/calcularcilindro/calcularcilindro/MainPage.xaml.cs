using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calcularcilindro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Asignación de entradas de pantalla a variables de calculo
            if(!string.IsNullOrEmpty(Diametro.Text) && 
               !string.IsNullOrEmpty(Espesor.Text) &&
               !string.IsNullOrEmpty(Temperatura.Text) )
            {
                var D = double.Parse(Diametro.Text);
                var Esp = double.Parse(Espesor.Text);
                var Ti = double.Parse(Temperatura.Text);
                double Df = 0.0;

                double Ai = (((D * D) * 3.141592654) / 4);
                double iT = 150 - Ti;
                var Af = (2 * (0.000012) * (Ai) * (iT)) + Ai;
                var DF = Math.Sqrt((((4) * (Af)) / (3.141592654)));
                var Apr = DF - D;
                var D2 = (D) + (2 * Esp);
                var Ai2 = (((D2 * D2) * 03.141592654) / 4);
                var Af2 = (2 * (0.0000224) * (Ai2) * (iT) + Ai2);
                var DF2 = Math.Sqrt((((4) * (Af2)) / (3.141592654)));
                var Apr2 = DF2 - D2;
                var Apriete = Apr2 - Apr;
                var AprieteMilecimas = (Apriete) * (1000);
                var Tolerancia = AprieteMilecimas / 5.2;
                var DilCal = Apriete + (0.35 * Apriete);
                var Af3 = ((((D2 * D2) + DilCal) * 3.141592654) / 4);
                var IA = Af3 - Ai2;
                var K = (2) * (0.0000224) * (Ai2);
                var TemEnc = ((((IA / K) + 1) * 3.3) + Ti);
                var ToLo = TemEnc / 13;

                //Reducción de puto decimal
                float ResulApriete = (float)AprieteMilecimas;
                float ResulTolerancia = (float)Tolerancia;
                float ResulTemEnc = (float)TemEnc;
                float ResulToLo = (float)ToLo;

                TxAprieteMilecimas.Text = ResulApriete.ToString();
                TxTolerancia.Text = ResulTolerancia.ToString();
                TxTemEnc.Text = ResulTemEnc.ToString();
                TxToLo.Text = ResulToLo.ToString();

                DisplayAlert("Calculo Realizado", "Seleciona ACEPTAR para ver los resultados",
                             "Aceptar");
            }
            else
            {
                DisplayAlert("Datos erroneos","Ingrese todos los datos porfavor", "Aceptar");
            }

        }
    }
}
