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
    
    /// Interaction logic for dodavanjeLokala.xaml
    /// </summary>
    public partial class dodavanjeLokala : Window
    {
        
        private string src1;
        private Lokal lokal;
        public dodavanjeLokala()
        {
            InitializeComponent();
            cmbTip.ItemsSource = MainWindow.tipovi;
            listBox.ItemsSource = MainWindow.etikete;
            List<String> selektovani = new List<String>();
        }
        public dodavanjeLokala(Lokal l)
        {
            InitializeComponent();
            lokal = new Lokal(l.oznaka,l.ime,l.opis,l.tipLokala,l.ikonica,l.alkohol,l.hendikepirani,l.pusenje,l.rezervacije,l.cena,l.kapacitet,l.datum);

            textBox.Text = l.oznaka;
            textBox1.Text = l.ime;
            textBox2.Text = l.opis;
            cmbTip.ItemsSource = MainWindow.tipovi;
            cmbTip.Text = l.tipLokala;
            ikonica.Source = l.ikonica;
            listBox.ItemsSource = MainWindow.etikete;
            comboBox.Text = l.alkohol;
            if (l.hendikepirani == true)
            {
                checkBox1.IsChecked=true;
            }
            if (l.pusenje == true)
            {
                checkBox2.IsChecked = true;
            }
            if (l.rezervacije == true)
            {
                checkBox3.IsChecked = true;
            }
            comboBox1.Text = l.cena;
            textBox3.Text = l.kapacitet;
            datum.Text = l.datum;
           
            MainWindow.lokali.Remove(l);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonIkonica_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.Filter = "Images (*.jpg;*.png)|*.jpg;*.png";
            ofd.Title = "Select Image";
            Nullable<bool> result = ofd.ShowDialog();
            if (result == true)
            {
                //BitmapImage src = new BitmapImage(new Uri(ofd.FileName));
                //textBoxIkonica.Text = ofd.FileName;
                ikonica.Source = new BitmapImage(new Uri(ofd.FileName));
            }
            src1 = ofd.FileName;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {//string oznaka, string ime, string opis, ImageSource ikonica,string alkohol, bool hendikepirani, bool pusenje, bool rezervacije, string cena, string kapacitet, DateTime datum)
            this.Close();
            bool hendikep = false;
            bool pusenje = false;
            bool rezer = false;
            if (checkBox1.IsChecked == true)
            {
                hendikep = true;
            }
            if (checkBox2.IsChecked == true)
            {
                pusenje = true;
            }
            if (checkBox3.IsChecked == true)
            {
                rezer = true;
            }
            Lokal lok = new Lokal(textBox.Text,textBox1.Text,textBox2.Text,cmbTip.Text,ikonica.Source,/*MainWindow.selektovani,*/comboBox.Text,hendikep,pusenje,rezer,comboBox1.Text,textBox3.Text,datum.Text);
            MainWindow.lokali.Add(lok);
            prikazLokala pl = new prikazLokala();
            pl.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           /* foreach (string item in listBox.SelectedItems)
            {
                MainWindow.selektovani.Add(item);
            }*/

        }
        /* try {
        // Adding new items into the cmbMovieListingBox 
         foreach(Tip tip in MainWindow.tipovi)
            cmbTip.Items.Add(Tip.get);
        finally {
            cmbTip.EndUpdate(); // <- Finally, repaint if required
            }*/
    }
}
