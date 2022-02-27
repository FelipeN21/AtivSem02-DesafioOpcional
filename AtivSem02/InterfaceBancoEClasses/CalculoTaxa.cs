using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    internal class CalculoTaxa : IBancos
    {
        public double Metodo1()
        {

            Console.WriteLine("Operacao Concluida");
            return 0;
        }

        public void Metodo2(double Variavel)
        {
            double NovaTaxa = Variavel * 0.25;
            Metodo1();
        }
    }
}
