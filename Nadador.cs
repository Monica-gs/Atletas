using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atletas
{
    public class Nadador : Atleta, INadador 
    {
        public void nadar() { }
        public override void VerHabilidades()
        {
            MessageBox.Show(nome + " sabe Nadar.");
        }

        public override void VerAcao()
        {
            MessageBox.Show(nome + " está Nadando.");
        }
    }
}
