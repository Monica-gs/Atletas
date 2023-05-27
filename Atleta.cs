using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atletas
{
    public class Atleta : IAtleta
    {
        public String nome = "";
        public virtual void VerHabilidades() { }

        public virtual void VerAcao() { }

    }
}
