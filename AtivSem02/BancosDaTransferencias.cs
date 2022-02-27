using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    public class BancosDaTransferencias
    {

        /// <summary>
        /// Classe do Banco 1 Contem seus atributos e funcoes/metodos
        /// </summary>
        public class Banco01 : IBancosTransfer
        {

            public string Nome;
            public string Codigo;
            public double Saldo;
            public Banco01()
            { 
            Nome = "Banco01";
            Codigo = "BDA";
             Saldo = 500.0;
        }
        public double TransferirParaOutroBanco(double valor)
            {
                this.Saldo -= valor;

                Console.WriteLine($"{this.Nome} Notifica : Transferencia realizada no valor de : {valor}");
                return valor;
            }

            public void Receber(double valor)
            {
                this.Saldo += valor;
            }
        }

        /// <summary>
        /// Classe do Banco 2 Contem seus atributos e funcoes/metodos
        /// </summary>
        public class Banco02 : IBancosTransfer
        {

            public string Nome;
            public string Codigo;
            public double Saldo;
            public Banco02()
            {
            Nome = "Banco02";
            Codigo = "BB";
            Saldo = 500.0;
        }

            public double TransferirParaOutroBanco(double valor)
            {
                this.Saldo -= valor;

                
                return valor;

            }
            public void Receber(double valor)
            {
                this.Saldo += valor;
                Console.WriteLine($"{this.Nome} Notifica : Transferencia Recebida no valor de : {valor}");
            }



        }

    }
}
