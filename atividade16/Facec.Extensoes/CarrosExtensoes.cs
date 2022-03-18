using Facec.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Extensoes
{
    public static class CarrosExtensoes
    {
        public static string ObterVelocidadeFinal(this AbstractCarro carro)
        {
            return $"{carro.ObterMarca()} - {carro.ObterModelo()} :" +
                $"{carro.ObterVelocidade()} km/h";
        }
        
    }
}
