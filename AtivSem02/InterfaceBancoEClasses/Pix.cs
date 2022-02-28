using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    internal class Pix : IBancos
    {
        /// <summary>
        /// Funcao envia o Pix
        /// </summary>
        /// <returns></returns>
        public double Metodo1()
        {
            double EnvioPix = 50;
            Metodo2(EnvioPix);
            return EnvioPix;
           
        }

        /// <summary>
        /// Funcao Registra o Pix e adiciona a taxa
        /// </summary>
        /// <param name="Variavel"></param>
        public void Metodo2(double Variavel)
        {
            double PixRegister = Variavel;
            double TaxaAdicional = 5.0;
            PixRegister = PixRegister + TaxaAdicional;
        }
    }
}
