using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    internal interface IBancosTransfer
    {
        /// <summary>
        /// Funcao de transferencia bancaria
        /// </summary>
        /// <param name="valor">Valor a Ser transferido</param>
        public double TransferirParaOutroBanco(double valor);

        public void Receber(double valor)
        { 
        
        }



        /*Seria Possivel a implementacao de uma funcao de transferencia em que seria escolhido
         * o bando destino, entretanto como so existem dois bancos o direcionamento foi realizado diretamente.
         * A execução contempla a transferencia B1 -> B2 entretando tambem é possivel B2 -> B1
        */
    }
}
