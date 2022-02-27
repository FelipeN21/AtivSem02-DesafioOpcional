using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    internal class TransferenciasBancarias 
    {
        IBancosTransfer _BancoAEnviar;
        IBancosTransfer _BancoAReceber;
        public TransferenciasBancarias(IBancosTransfer BancoAEnviar, IBancosTransfer BancoAReceber)
        {
            _BancoAEnviar = BancoAEnviar;
            _BancoAReceber = BancoAReceber;
        }


        /// <summary>
        /// Funcao Realiza a trasnferencia entre dois bancos especificados
        /// </summary>
        public void Transferir(double valor)
        {

            _BancoAReceber.Receber(_BancoAEnviar.TransferirParaOutroBanco(valor));
        }
    }
}
