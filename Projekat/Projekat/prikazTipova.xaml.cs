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
    /// Interaction logic for prikazTipova.xaml
    /// </summary>
    public partial class prikazTipova : Window
    {
        public prikazTipova()
        {
            InitializeComponent();
            this.DataContext = this;
            tabela1.ItemsSource = MainWindow.tipovi;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            dodavanjeTipa dt = new dodavanjeTipa((Tip)tabela1.SelectedItem);
            dt.Show();
        }
    }
}
