using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15_03
{
    internal class Pessoa
    {
        public string Nome { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome ??
                throw new ArgumentNullException(nameof(nome));
        }
    }
}
