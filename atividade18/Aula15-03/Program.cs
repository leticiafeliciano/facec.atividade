using System;

namespace Aula15_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region val
            //string nome1 = "Guilherme";
            //string nome2 = nome1;

            //nome1 = "Natan";

            //Console.WriteLine($"{nameof(nome1)} : {nome1}");
            //Console.WriteLine($"{nameof(nome2)} : {nome2}");

            //Console.ReadLine();
            #endregion val

            #region Tipo de Referencia

            //Pessoa pessoa = new Pessoa();
            //{
            //    Nome = "Valdivino";
            //};

            //pessoa.Nome = "Adalberto";

            //Pessoa pessoa = new Pessoa(null);

            //Pessoa pessoa1 = new Pessoa("Guilherme");
            //Pessoa pessoa2 = pessoa1;

            //pessoa1.Nome = "Valdivino";

            Pessoa pessoa1 = new Pessoa("Guilherme");
            Pessoa pessoa2 = pessoa1;

            pessoa1 = new Pessoa("Edmervan");
            pessoa2 = pessoa1;

            Console.WriteLine($"{nameof(pessoa1)}: " + $"{pessoa1.Nome}");
            Console.WriteLine($"{nameof(pessoa1)}: " + $"{pessoa2.Nome}");

            Console.ReadLine();

            #endregion Tipo de Referencia
        }
    }
}
