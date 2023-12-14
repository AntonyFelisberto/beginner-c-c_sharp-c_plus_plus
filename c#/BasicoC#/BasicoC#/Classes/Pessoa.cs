using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicoC_.Classes
{
    internal class Pessoa
    {
        public int andar()
        {
            return 1;
        }

        public int andar(int lvl)
        {
            return andar() * lvl;
        }

        public int correr() 
        {
            return andar() * 2;
        }

        public int pedalar() 
        {
            return andar() * 4;
        }
    }
}
