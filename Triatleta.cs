using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atletas
{
    public class Triatleta : Atleta, ITriatleta
    {
        public void correr() { }
        public void nadar() { }
        public void pedalar() { }


        public override void VerHabilidades()
        {
            MessageBox.Show(nome + " sabe Correr, nadar e pedalar");
        }

        public override void VerAcao()
        {
            MessageBox.Show(nome + " estará correndo, depois nadando e depois pedalando.");
        }
    }
}
