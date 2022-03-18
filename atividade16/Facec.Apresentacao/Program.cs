using Facec.Classes;
using Facec.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Apresentacao
{
    public class Program
    {
     static void Main(string[] arggs)
        {
            #region Chamada método extension
            //ImprimirVelocidadeFinal(new Cooper());
            //ImprimirVelocidadeFinal(new Fusca());
            #endregion Chamada método extension

            #region Classe partial
            ImprimirMembrosHumano(new Humano());
            #endregion Classe partial

            #region Struct

            var posicaoGPS = new PosicaoGPS(15.00m, -50.00m);

            Console.WriteLine($"Está no hemustério norte: {posicaoGPS.IsHemisferioNorte()}");
            #endregion Struct

            Console.ReadLine();
        }

        static void ImprimirVelocidadeFinal(AbstractCarro carro)
        {
            Console.WriteLine(carro.ObterVelocidadeFinal());
        }

        static void ImprimirMembrosHumano(Humano humano)
        {
            Console.WriteLine($"{humano.Bracos} - {humano.Quadril}");
        }
#endregion
    }
}
