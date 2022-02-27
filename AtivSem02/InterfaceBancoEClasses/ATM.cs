using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    internal class ATM : IBancos
    {

        public double Metodo1()
        {

            return 500;
        }
        private double Metodo1(double valor)
        {
            Console.WriteLine(valor);
            return valor;
        }


        public void Metodo2(double Variavel)
        {
            double NovoSaldo = Metodo1() - Variavel;
            Metodo1(NovoSaldo);
        
        }
    }
}
