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
    //private string src1;
    /// Interaction logic for dodavanjeTipa.xaml
    /// </summary>
    public partial class dodavanjeTipa : Window
    {
        private string src1;
        private Tip tip;
        public dodavanjeTipa()
        {
            InitializeComponent();
        }
        public dodavanjeTipa(Tip t)
        {
            InitializeComponent();
            tip = new Tip(t.oznaka, t.ime,t.ikonica, t.opis);
            textBox2.Text = t.oznaka;
            textBox1.Text = t.ime;
            ikonica.Source = t.ikonica;
            textBox.Text = t.opis;
            MainWindow.tipovi.Remove(t);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Tip t = new Tip(textBox2.Text,textBox1.Text,ikonica.Source, textBox.Text);
            MainWindow.tipovi.Add(t);
            prikazTipova pt = new prikazTipova();
            pt.Show();


        }
    }
}
