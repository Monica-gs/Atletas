using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atletas
{
    public class Corredor:Atleta, ICorredor
    {
        public void correr() { }

        public override void VerHabilidades()
        {
            MessageBox.Show(nome + " sabe Correr.");
        }

        public override void VerAcao()
        {
            MessageBox.Show(nome + " está correndo.");
        }
    }
}
