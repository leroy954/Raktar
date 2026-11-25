using System;
using System.Collections.Generic;
using System.IO;
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

namespace Raktár
{
    /// <summary>
    /// Interaction logic for Eladas.xaml
    /// </summary>
    public partial class Eladas : Window
    {
        public Eladas()
        {
            InitializeComponent();
            foreach (Termekek t in Window1.termek)
            {
                cbxEladas.Items.Add(t.Termek);
            }
        }

        private void btnFomenu_Click(object sender, RoutedEventArgs e)
        {
            Menuoldal m1 = new Menuoldal();
            m1.Show();
            this.Hide();
        }

        private void cbxEladas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            

        }

        private void btnEladas_Click(object sender, RoutedEventArgs e)
        {
            string termeknev = cbxEladas.SelectedItem.ToString();
            DateTime datum = DateTime.Parse(tbxDatum.Text);
            int mennyiseg = int.Parse(tbxMennyiseg.Text);

            MessageBox.Show("Sikeres eladás!");

            Window1.eladasok.Add(new Elad(termeknev, datum, mennyiseg));
            StreamWriter sw = new StreamWriter("eladasok.txt", true);
            sw.WriteLine($"{termeknev}; {datum}; {mennyiseg}");
            sw.Close();
        }

    }
}
