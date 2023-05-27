using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atletas
{
    public interface ITriatleta : IAtleta
    {
        void pedalar();
        void correr();
        void nadar();
    }
}
