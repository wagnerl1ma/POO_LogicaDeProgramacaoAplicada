using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO_List
{
    class Aluno
    {
        public string Nome { get; private set; }

        private List<double> Notas { get; set; } = new List<double>();

        public int QtdProva { get; set; }

        public double Media { get { return CalcularMedia(); } }

        public Aluno(string nome, int qtdProvas)
        {
            Nome = nome;
            QtdProva = qtdProvas;
            //Notas = new List<double> { 0 };
            //var resultado = Notas[0];
        }

        public void InserirNotas()
        {

            for (int i = 0; i < QtdProva; i++)
            {

                Console.Write("Nota #" + (i + 1) + ": ");
                Notas.Add(double.Parse(Console.ReadLine()));

                //ou
                //Notas[i] = double.Parse(Console.ReadLine());
                //Notas.Add(i);
            }

        }



        private double CalcularMedia()
        {
            double total = 0;

            for (int i = 0; i < QtdProva; i++)
            {
                total += Notas[i];
            }

            return total / Notas.Count;
        }
    }
}
