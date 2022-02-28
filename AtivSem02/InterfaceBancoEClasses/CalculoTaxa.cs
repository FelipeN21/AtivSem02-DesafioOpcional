using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    internal class CalculoTaxa : IBancos
    {

        /// <summary>
        /// Funcao mostra na tela a operacao sendo concluida
        /// </summary>
        /// <returns></returns>
        public double Metodo1()
        {

            Console.WriteLine("Operacao Concluida");
            return 0;
        }

        /// <summary>
        /// Funcao calcula a Taxa a ser paga
        /// </summary>
        /// <param name="Variavel">Valor base para se calcular a taxa</param>
        public void Metodo2(double Variavel)
        {
            double NovaTaxa = Variavel * 0.25;
            Metodo1();
        }
    }
}
