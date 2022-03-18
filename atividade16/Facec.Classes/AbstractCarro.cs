using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Classes
{
    public abstract class AbstractCarro
    {
        public abstract string ObterMarca();
        public abstract string ObterModelo();
        public abstract int ObterVelocidade();
        

        //Não permite sobrescrita
        //public string RelatorioDeManutencao()
        //{
        //
        //    return $"{ObterMarca()} -" +
        //           $" {ObterModelo()}\n" +
        //           $"TESTE TESTE";
        //}

        internal virtual string RelatorioDeManutencao()
        {

            return $"{ObterMarca()} -" +
                   $" {ObterModelo()}\n" +
                   $"TESTE TESTE";
        }
    }
}
