using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atletas
{
    public class Ciclista : Atleta, ICiclista
    {
        public void pedalar() { }

        public override void VerHabilidades()
        {
            MessageBox.Show(nome + " sabe pedalar.");
        }

        public override void VerAcao()
        {
            MessageBox.Show(nome + " está pedalando.");
        }
    }
}
