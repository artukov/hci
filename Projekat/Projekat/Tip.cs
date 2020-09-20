using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Projekat
{
    public class Tip
    {
        public string oznaka { get; set; }
        public string ime { get; set; }

        public ImageSource ikonica { get; set; }
        public string opis { get; set; }

        public override string ToString()
        {
            return this.oznaka;
        }

        public Tip(string oznaka, string ime,ImageSource ikonica, string opis)
        {
            this.oznaka = oznaka;
            this.ime = ime;
            this.ikonica = ikonica;
            this.opis = opis;
        }
    }
}
