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
    /// Interaction logic for prikazEtiketa.xaml
    /// </summary>
    public partial class prikazEtiketa : Window
    {
        public prikazEtiketa()
        {
            InitializeComponent();
            this.DataContext = this;
            tabela2.ItemsSource = MainWindow.etikete;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

            InitializeComponent();
            dodavanjeEtikete et = new dodavanjeEtikete((Etiketa)tabela2.SelectedItem);
            et.Show();
        }
    }
}
