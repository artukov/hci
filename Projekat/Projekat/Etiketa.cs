using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    public class Etiketa
    {
        public string oznaka { get; set; }
        public string boja { get; set; }
        public string opis { get; set; }

        public override string ToString()
        {
            return this.oznaka;
        }

        public Etiketa(string oznaka, string boja, string opis)
        {
            this.oznaka = oznaka;
            this.boja = boja;
            this.opis = opis;
        }
    } 
}
