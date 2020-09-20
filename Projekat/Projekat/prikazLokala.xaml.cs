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
    /// Interaction logic for prikazLokala.xaml
    /// </summary>
    public partial class prikazLokala : Window
    {
        public prikazLokala()
        {
            InitializeComponent();
            this.DataContext = this;
            tabela3.ItemsSource = MainWindow.lokali;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            InitializeComponent();
            dodavanjeLokala l = new dodavanjeLokala((Lokal)tabela3.SelectedItem);
            l.Show();
        }
    }
}
