using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Classes
{
    public sealed class Cooper : AbstractCarro
    {
        public override string ObterMarca()
        {
            return "Mini";
        }

        public override string ObterModelo()
        {
            return "Cooper";
        }

        public override int ObterVelocidade()
        {
            return 180;
        }

        internal     override string RelatorioDeManutencao()
        {
            return $"Este método foi sobreescrito\n" + 
                base.RelatorioDeManutencao();
        }
    }
}
