using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    internal class ATM : IBancos
    {
        /// <summary>
        /// Funcao de implementacao basica, so retorna 500
        /// </summary>
        /// <returns></returns>
        public double Metodo1()
        {

            return 500;
        }

        /// <summary>
        /// Funcao que recebe e mostra na tela um valor passado por paramentro
        /// </summary>
        /// <param name="valor">Valor a ser escrito na tela</param>
        /// <returns></returns>
        private double Metodo1(double valor)
        {
            Console.WriteLine(valor);
            return valor;
        }

        /// <summary>
        /// Funcao que debita um valor e atualiza o saldo
        /// </summary>
        /// <param name="Variavel">Valor a ser debitado</param>
        public void Metodo2(double Variavel)
        {
            double NovoSaldo = Metodo1() - Variavel;
            Metodo1(NovoSaldo);
        
        }
    }
}
