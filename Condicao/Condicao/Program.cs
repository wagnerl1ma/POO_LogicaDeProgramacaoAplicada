using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Condição simples
            //int valor = 7;

            //if (valor < 5)
            //{
            //    Console.WriteLine("Condição verdadeira");
            //}
            //else
            //{
            //    Console.WriteLine("Condição retornou falso");
            //}
            #endregion

            #region Condição encadeada
            //int valor = 25;

            //if (valor < 5)
            //{
            //    Console.WriteLine("Condição verdadeira");
            //}
            //else if (valor >= 5 && valor < 10)
            //{
            //    Console.WriteLine("Condição alternativa 1");
            //}
            //else if (valor >= 10 && valor < 20)
            //{
            //    Console.WriteLine("Condição alternativa 2");
            //}
            //else
            //{
            //    Console.WriteLine("Condição alternativa final");
            //}
            #endregion

            #region Condição aninhada
            //int numero = 13;

            //if (numero > 5)
            //{
            //    Console.Write("O número é maior que 5");

            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine(" é também é par.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" mas não é par.");
            //    }
            //}

            #endregion

            #region Operador ternário
            int numero = 3;
            string mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";

            //condição ? true : false;
            mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";

            if (numero > 5)
            {
                mensagem = "Maior que 5";
            }
            else
            {
                mensagem = "Menor que 5";
            }

            Console.WriteLine(numero > 5 ? "Maior que 5" : "Menor que 5");

            #endregion

            Console.ReadKey();
        }
    }
}
