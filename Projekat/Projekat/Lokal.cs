using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Projekat
{
    public class Lokal
    {
       

        public string oznaka { get; set; }
        public string ime { get; set; }
        public string opis { get; set; }
       // public string tipLokala { get; set; }
        public Tip tipLokala { get; set; }
        public ImageSource ikonica { get; set; }
        public List<Etiketa> etikete { get; set; }
      // public string etiketa { get; set; }
       // public List<String> etiketa { get; set; }
        public string alkohol { get; set; }
        public bool hendikepirani { get; set; }
        public bool pusenje { get; set; }
        public bool rezervacije { get; set; }
        public string cena { get; set; }
        public string kapacitet { get; set; }
        public string datum { get; set; }
        
        public override string ToString()
        {
            return this.ime;
        }

       

        /*public Lokal(string oznaka, string ime, string opis,Tip tipLokala,ImageSource ikonica,List<String> etiketa, string alkohol,bool hendikepirani, bool pusenje, bool rezervacije, string cena, string kapacitet, string datum)
        {
            this.oznaka = oznaka;
            this.ime = ime;
            this.opis = opis;
            this.tipLokala = tipLokala;
            this.ikonica = ikonica;
            //this.etiketa = etiketa;
            this.alkohol = alkohol;
            this.hendikepirani = hendikepirani;
            this.pusenje = pusenje;
            this.rezervacije = rezervacije;
            this.cena = cena;
            this.kapacitet = kapacitet;
            this.datum = datum;
        }*/


    }
}
