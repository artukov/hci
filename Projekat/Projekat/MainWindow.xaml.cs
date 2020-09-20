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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekat
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        public static List<String> selektovani;
        public static List<Tip> tipovi;
        public static List<Etiketa> etikete;
        public static List<Lokal> lokali;
        public MainWindow()
        {
            InitializeComponent();
            tipovi = new List<Tip>();
            etikete = new List<Etiketa>();
            lokali = new List<Lokal>();

        }

        private void dodajTip_Click(object sender, RoutedEventArgs e)
        {
            dodavanjeTipa dt = new dodavanjeTipa();
            dt.Show();
           
           
        }

        private void dodajEtiketu_Click(object sender, RoutedEventArgs e)
        {
            dodavanjeEtikete de = new dodavanjeEtikete();
            de.Show();
        }

        private void dodajLokal_Click(object sender, RoutedEventArgs e)
        {
            dodavanjeLokala dl = new dodavanjeLokala();
            dl.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            prikazTipova pt = new prikazTipova();
            pt.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            prikazEtiketa pe = new prikazEtiketa();
            pe.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            prikazLokala pl = new prikazLokala();
            pl.Show();
        }
    }
}
