using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "### Média Geral dos Alunos ###";

            Console.Write("Quantos alunos? ");
            int nAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            List<Aluno> alunos = new List<Aluno>();

            for (int i = 0; i < nAlunos; i++)
            {
                Console.Clear();
                Console.Write("Aluno #" + (i + 1) + " Nome..: ");
                string nome = Console.ReadLine();

                Console.Write("Aluno #" + (i + 1) + " Provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos.Add(new Aluno(nome, provas));
                //alunos[i] = new Aluno(nome, provas);

                Console.WriteLine("Insira as notas do aluno: " + nome);
                alunos[i].InserirNotas();

            }


            Console.Clear();

            double mediaGeral = 0;

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine("Media: " + aluno.Media);
                Console.WriteLine();

                mediaGeral += aluno.Media;

            }

            double resultadoFinal = mediaGeral / alunos.Count;

            Console.WriteLine("Média geral dos alunos: " + resultadoFinal);

            Console.ReadKey();
        }
    }
}
