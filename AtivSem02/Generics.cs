using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    public class Generics
    {

        public class Alunos
        {
            /// <summary>
            /// Construtor sem parametragem
            /// </summary>
            public Alunos()
            {
                this.nome = "AlunoQualquer";
                this.idade = 0;
                this.notaFinal = 0;


            }
            /// <summary>
            /// Construtor parametrado com todos atributos
            /// </summary>
            /// <param name="nome">Nome do aluno</param>
            /// <param name="idade">Idade do aluno</param>
            /// <param name="notaFinal">Nota Final do aluno</param>
            public Alunos(string nome,int idade, int notaFinal)
            {
                this.nome = nome;
                this.idade = idade;
                this.notaFinal = notaFinal;


            }
            public string nome { get; set; }
            public int idade { get; set; }
            public int notaFinal { get; set; }


       

        }

        /// <summary>
        /// Preenche a lista com os alunos passados
        /// </summary>
        /// <typeparam name="T">Tipo generico da lista</typeparam>
        /// <param name="alunoQualquer">Array de alunos a serem adicionados na lista</param>
        /// <returns></returns>
        public static List<T> Funcao<T>(T[] alunoQualquer)
        {
            List<T> list = new List<T>();
            for(int i = 0;i < 10 ;i++ )
            { 
            list.Add(alunoQualquer[i]);
            }
          



            return list;
        }


        /// <summary>
        /// Funcao que recebe a lista generica e pesquisa alunos na mesma
        /// </summary>
        /// <typeparam name="Alunos"></typeparam>
        /// <param name="listaDosAlunos">Lista generica a ser analisada</param>
        /// <param name="nomeBuscado">Nome o qual deve ser buscado na lista</param>
        /// <returns></returns>
        public static Generics.Alunos BuscarAlunoPeloNome<Alunos>(List<Generics.Alunos> listaDosAlunos,string nomeBuscado )
        {

            try
            {

                var filtro = listaDosAlunos.Where(a => a.nome.Equals(nomeBuscado)).Select(a => a);


                Generics.Alunos[] array = filtro.ToArray();

                Console.WriteLine(array.GetType().Name);
                Generics.Alunos Salvar = new Generics.Alunos();
                foreach (Generics.Alunos listado in array)
                {
                    Console.WriteLine("\nNome : " + listado.nome + "\nIdade : " + listado.idade + "\nNota Final : " + listado.notaFinal + "\n");
                    Salvar = listado;
                }




                return Salvar;
            }
            catch (Exception ex) { 
                Console.WriteLine("Aluno escolhido não encontrado na lista Ou lista Incompativel");
            Console.Write(ex.Message);
                Generics.Alunos Erro = new Generics.Alunos {nome = "ERRO : ALUNO NAO EXISTENTE" };
                return Erro;
            }
        }

    }


}
