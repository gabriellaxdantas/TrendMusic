using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Media
{
    internal class celula
    {
        public string val;
        public celula apontador;
        public celula()
        {
            val = "";
            apontador = null;
        }
        public celula(string val)
        {
            this.val = val;
            apontador = null;
        }
    }
}
