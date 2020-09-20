using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for dodavanjeEtikete.xaml
    /// </summary>
    /// 
    
    public partial class dodavanjeEtikete : Window
    {
        private Etiketa etiketa;
        public dodavanjeEtikete()
        {
            InitializeComponent();
        }
        public dodavanjeEtikete(Etiketa et)
        {
            InitializeComponent();
            etiketa = new Etiketa(et.oznaka, et.boja, et.opis);
            textBox.Text = et.oznaka;

            boja.Text = et.boja;
            textBox1.Text = et.opis;
            MainWindow.etikete.Remove(et);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Etiketa etik = new Etiketa(textBox.Text,boja.Text,textBox1.Text);
            MainWindow.etikete.Add(etik);
            prikazEtiketa pe = new prikazEtiketa();
            pe.Show();
            
        }
    }
}
