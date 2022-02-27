using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    internal class Pix : IBancos
    {
        public double Metodo1()
        {
            double EnvioPix = 50;
            Metodo2(EnvioPix);
            return EnvioPix;
           
        }

        public void Metodo2(double Variavel)
        {
            double PixRegister = Variavel;
            double TaxaAdicional = 5.0;
            PixRegister = PixRegister + TaxaAdicional;
        }
    }
}
