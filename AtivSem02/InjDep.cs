using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtivSem02;

namespace AtivSem02
{
    internal class InjDep
    {
        
        
        public static void Main(string[] args)
        {


            //Tarefa 2 -------
            Generics.Alunos Teste1 = new Generics.Alunos();
            Generics.Alunos[] arrayDeAlunos = { 
            new Generics.Alunos("Rodrigo", 20, 99),
            new Generics.Alunos("Felipe", 19, 50), 
            new Generics.Alunos("Rodrigo", 18, 65), 
            new Generics.Alunos("Leticia", 28, 62), 
            new Generics.Alunos("Luana", 36, 61),
            new Generics.Alunos("Gabriela",40,60),
            new Generics.Alunos("Fernando",30,55),
            new Generics.Alunos("Pedro",50,55),
            new Generics.Alunos("Igor",99,77),
            new Generics.Alunos("Laura",11,88)};

            
            List<Generics.Alunos> listaAlunos = Generics.Funcao<Generics.Alunos>(arrayDeAlunos);
            //Pode-se mudar o ultimo parametro <Nome> para poder procurar outros alunos
            //Detalhe Importante -> Seria possivel retornar mais de um aluno com mesmo nome por meio de um array
            //Mas dadas as instrucoes do exercicio so sera retornado 1.
            Generics.BuscarAlunoPeloNome<Generics.Alunos>(Generics.Funcao<Generics.Alunos>(arrayDeAlunos), "Rodrigo");




            //Tarefa 3 -------
            TransferenciasBancarias Teste = new TransferenciasBancarias(new BancosDaTransferencias.Banco01(),new BancosDaTransferencias.Banco02());
            Teste.Transferir(50);
            Console.ReadKey();
        }
       
    }
}
